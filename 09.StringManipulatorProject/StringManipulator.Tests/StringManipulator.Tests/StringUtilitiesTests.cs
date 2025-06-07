using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringManipulator;

namespace StringManipulator.Tests
{
    [TestClass]
    public class StringUtilitiesTests
    {
        [TestMethod]
        public void TestIsPalindrome_True()
        {
            Assert.IsTrue(StringUtilities.IsPalindrome("A man a plan a canal Panama"));
        }

        [TestMethod]
        public void TestIsPalindrome_False()
        {
            Assert.IsFalse(StringUtilities.IsPalindrome("Hello World"));
        }
    }
}
