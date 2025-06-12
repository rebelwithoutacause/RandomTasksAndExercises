using Xunit;
using PadlockApp;

namespace PadlockApp.Tests
{
    public class PadlockTests
    {
        [Fact]
        public void Unlock_WithCorrectCode_ReturnsUnlocked()
        {
            var padlock = new Padlock("123");
            var result = padlock.TryUnlock("123");
            Assert.Equal("Unlocked!", result);
        }

        [Fact]
        public void Unlock_WithIncorrectCode_ReturnsHint()
        {
            var padlock = new Padlock("123");
            var result = padlock.TryUnlock("321");
            Assert.Contains("digits in the correct position", result);
        }

        [Fact]
        public void Unlock_WithTooManyAttempts_ReturnsLockedOut()
        {
            var padlock = new Padlock("123");
            padlock.TryUnlock("000");
            padlock.TryUnlock("111");
            var result = padlock.TryUnlock("222");
            Assert.Equal("Locked out!", result);
        }

        [Fact]
        public void Unlock_AfterLockout_ReturnsLockedOut()
        {
            var padlock = new Padlock("123");
            padlock.TryUnlock("000");
            padlock.TryUnlock("111");
            padlock.TryUnlock("222");
            var result = padlock.TryUnlock("123");
            Assert.Equal("Locked out!", result);
        }
    }
}
