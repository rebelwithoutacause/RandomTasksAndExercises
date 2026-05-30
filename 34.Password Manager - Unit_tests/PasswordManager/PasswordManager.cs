using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace PasswordManager;

public record PasswordEntry(string Website, string Username, string PasswordEncrypted, string Salt);

public record SearchResult(string Website, string Username, string Password);

public class PasswordStrengthException(string message) : Exception(message);
public class DuplicateEntryException(string message) : Exception(message);
public class EntryNotFoundException(string message) : Exception(message);

public class PasswordManager
{
    private readonly string _dataFile;

    public PasswordManager(string? dataFile = null)
    {
        _dataFile = dataFile ?? Path.Combine(AppContext.BaseDirectory, "passwords.json");
    }

    // --- Validation ---

    public static (bool IsStrong, string Reason) ValidatePasswordStrength(string password)
    {
        if (password.Length < 8)
            return (false, "Password must be at least 8 characters long.");
        if (!Regex.IsMatch(password, @"[A-Z]"))
            return (false, "Password must contain at least one uppercase letter.");
        if (!Regex.IsMatch(password, @"[a-z]"))
            return (false, "Password must contain at least one lowercase letter.");
        if (!Regex.IsMatch(password, @"\d"))
            return (false, "Password must contain at least one digit.");
        if (!Regex.IsMatch(password, @"[!@#$%^&*()\-_=+\[\]{};':""\\|,.<>/?]"))
            return (false, "Password must contain at least one special character.");
        return (true, "Password is strong.");
    }

    // --- CRUD ---

    public string SavePassword(string website, string username, string password)
    {
        if (string.IsNullOrWhiteSpace(website) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("Website, username, and password are required.");

        var (isStrong, reason) = ValidatePasswordStrength(password);
        if (!isStrong)
            throw new PasswordStrengthException($"Weak password: {reason}");

        var data = LoadData();
        if (data.Keys.Any(k => k.Equals(website, StringComparison.OrdinalIgnoreCase)))
            throw new DuplicateEntryException($"An entry for '{website}' already exists.");

        var salt = GenerateSalt();
        var entry = new PasswordEntry(website, username, Encrypt(password, salt), salt);
        data[website] = entry;
        SaveData(data);
        return $"Password for '{website}' Saved Successfully.";
    }

    public SearchResult? SearchEntry(string website)
    {
        var data = LoadData();
        var match = data.FirstOrDefault(kv => kv.Key.Equals(website, StringComparison.OrdinalIgnoreCase));
        if (match.Value is null) return null;

        var entry = match.Value;
        return new SearchResult(entry.Website, entry.Username, Decrypt(entry.PasswordEncrypted, entry.Salt));
    }

    public string DeleteEntry(string website)
    {
        var data = LoadData();
        var key = data.Keys.FirstOrDefault(k => k.Equals(website, StringComparison.OrdinalIgnoreCase));
        if (key is null)
            throw new EntryNotFoundException($"No entry found for '{website}'.");

        data.Remove(key);
        SaveData(data);
        return $"Entry for '{website}' deleted.";
    }

    public IReadOnlyList<string> ListEntries() => LoadData().Keys.ToList();

    // --- Persistence ---

    private Dictionary<string, PasswordEntry> LoadData()
    {
        if (!File.Exists(_dataFile)) return new Dictionary<string, PasswordEntry>();
        var json = File.ReadAllText(_dataFile);
        if (string.IsNullOrWhiteSpace(json)) return new Dictionary<string, PasswordEntry>();
        return JsonSerializer.Deserialize<Dictionary<string, PasswordEntry>>(json)
               ?? new Dictionary<string, PasswordEntry>();
    }

    private void SaveData(Dictionary<string, PasswordEntry> data)
    {
        File.WriteAllText(_dataFile, JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true }));
    }

    // --- Crypto helpers ---

    private static string GenerateSalt() => Convert.ToHexString(RandomNumberGenerator.GetBytes(16));

    private static string Encrypt(string text, string salt)
    {
        var key = SHA256.HashData(Encoding.UTF8.GetBytes(salt));
        var bytes = Encoding.UTF8.GetBytes(text);
        var encrypted = bytes.Select((b, i) => (byte)(b ^ key[i % key.Length])).ToArray();
        return Convert.ToBase64String(encrypted);
    }

    private static string Decrypt(string encText, string salt)
    {
        var key = SHA256.HashData(Encoding.UTF8.GetBytes(salt));
        var encrypted = Convert.FromBase64String(encText);
        var decrypted = encrypted.Select((b, i) => (byte)(b ^ key[i % key.Length])).ToArray();
        return Encoding.UTF8.GetString(decrypted);
    }
}
