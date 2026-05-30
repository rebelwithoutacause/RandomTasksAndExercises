using NUnit.Framework;
using MagicNumber;

namespace MagicNumberTests
{
    public class MagicNumberCheckerTests
    {
        private MagicNumberChecker checker;

        [SetUp]
        public void Setup()
        {
            checker = new MagicNumberChecker();
        }

        [TestCase(3, ExpectedResult = true)]
        [TestCase(13, ExpectedResult = false)]
        [TestCase(9, ExpectedResult = false)]
        [TestCase(33, ExpectedResult = true)]
        [TestCase(-3, ExpectedResult = false)]
        [TestCase(0, ExpectedResult = false)]
        public bool TestIsMagicNumber(int number)
        {
            return checker.IsMagicNumber(number);
        }
    }
}