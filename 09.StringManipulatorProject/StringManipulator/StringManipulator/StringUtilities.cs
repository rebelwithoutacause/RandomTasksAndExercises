using System;

namespace StringManipulator
{
    public class StringUtilities
    {
        public static bool IsPalindrome(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;
            input = input.ToLower().Replace(" ", "");
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return input == new string(arr);
        }
    }
}
