using NUnit.Framework;
using System.IO;

namespace PasswordManager.Tests;

[TestFixture]
public class PasswordManagerTests
{
    private string _tempFile = string.Empty;
    private PasswordManager _pm = null!;

    [SetUp]
    public void SetUp()
    {
        _tempFile = Path.GetTempFileName();
        _pm = new PasswordManager(_tempFile);
    }

    [TearDown]
    public void TearDown() => File.Delete(_tempFile);

    [Test]
    public void WeakPassword_TooShort_IsRejected()
    {
        // Arrange
        string password = "Ab1!";

        // Act
        var result = PasswordManager.ValidatePasswordStrength(password);

        // Assert
        Assert.That(result.IsStrong, Is.False);
    }

    [Test]
    public void WeakPassword_NoUppercase_IsRejected()
    {
        // Arrange
        string password = "alice444!";

        // Act
        var result = PasswordManager.ValidatePasswordStrength(password);

        // Assert
        Assert.That(result.IsStrong, Is.False);
    }

    [Test]
    public void WeakPassword_NoSpecialChar_IsRejected()
    {
        // Arrange
        string password = "TeddQA123";

        // Act
        var result = PasswordManager.ValidatePasswordStrength(password);

        // Assert
        Assert.That(result.IsStrong, Is.False);
    }

    [Test]
    public void StrongPassword_IsAccepted()
    {
        //Arrange
        string password = "We@reAnonnymous666_";

        //Act
        var result = PasswordManager.ValidatePasswordStrength(password);

        //Assert
        Assert.That(result.IsStrong, Is.True);
        
    }

    [Test]
    public void SavePassword_ValidEntry_Succeeds()
    {
        //Arrange
        string website = "test.com";
        string username = "qa_tester_tedd";
        string password = "We@reAnonnymous666_";

        //Act
        var result = _pm.SavePassword(website, username, password);

        //Assert 
        Assert.That(result, Does.Contain("Saved Successfully"));

    }

    [Test]
    public void SavePassword_WeakPassword_ThrowsException()
    {
        // Arrange
        string website = "test.com";
        string username = "qa_tester_tedd";
        string password = "123456";

        // Act & Assert
        var ex = Assert.Throws<PasswordStrengthException>(() =>
            _pm.SavePassword(website, username, password));

        Assert.That(ex!.Message, Does.Contain("Weak password"));
    }

    [Test]
    public void SavePassword_DuplicateWebsite_ThrowsException()
    {
        // Arrange
        string website = "test.com";
        string username = "qa_tester_tedd";
        string password = "We@reAnonnymous666_";
        _pm.SavePassword(website, username, password);

        // Act & Assert
        var ex = Assert.Throws<DuplicateEntryException>(() =>
            _pm.SavePassword(website, username, password));

        Assert.That(ex!.Message, Does.Contain($"An entry for '{website}' already exists."));
    }

    [Test]
    public void SavePassword_MissingFields_ThrowsException()
    {
        // Arrange
        string website = "";
        string username = "qa_tester_tedd";
        string password = "We@reAnonnymous666_";

        //Act & Assert
        var ex = Assert.Throws<ArgumentException>(() =>
        _pm.SavePassword(website, username, password));

        Assert.That(ex!.Message, Does.Contain("required"));
    }

    [Test]
    public void SearchEntry_ReturnsCorrectResult()
    {
        // Arrange
        string website = "test.com";
        string username = "qa_tester_tedd";
        string password = "We@reAnonnymous666_";
        _pm.SavePassword(website, username, password);

        //Act
        var result = _pm.SearchEntry(website);

        //Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(result!.Username, Is.EqualTo(username));
        Assert.That(result!.Password, Is.EqualTo(password));
    }

    [Test]
    public void DeleteEntry_RemovesEntry()
    {
        // Arrange
        string website = "test.com";
        string username = "qa_tester_tedd";
        string password = "We@reAnonnymous666_";
        _pm.SavePassword(website, username, password);

        //Act
        var result = (_pm.DeleteEntry(website));

        //Assert 
        Assert.That(result, Does.Contain($"Entry for '{website}' deleted."));
        Assert.That(_pm.SearchEntry(website), Is.Null);
    }

    [Test]
    public void SearchEntry_NotFound_ReturnsNull()
    {
        // Arrange
        string website = "notfound.com";

        // Act
        var result = _pm.SearchEntry(website);

        // Assert
        Assert.That(result, Is.Null);
    }
}
