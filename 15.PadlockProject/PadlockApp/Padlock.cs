namespace PadlockApp
{
    public class Padlock
    {
        private readonly string _correctCode;
        private int _attempts;
        private const int MaxAttempts = 3;
        private bool _isLockedOut;

        public Padlock(string correctCode)
        {
            _correctCode = correctCode;
            _attempts = 0;
            _isLockedOut = false;
        }

        public string TryUnlock(string input)
        {
            if (_isLockedOut) return "Locked out!";
            if (_attempts >= MaxAttempts)
            {
                _isLockedOut = true;
                return "Locked out!";
            }

            _attempts++;
            if (input == _correctCode)
                return "Unlocked!";

            if (_attempts >= MaxAttempts)
            {
                _isLockedOut = true;
                return "Locked out!";
            }

            return ProvideHint(input);
        }

        private string ProvideHint(string input)
        {
            int correctPosition = 0;
            for (int i = 0; i < input.Length && i < _correctCode.Length; i++)
            {
                if (input[i] == _correctCode[i])
                    correctPosition++;
            }
            return $"{correctPosition} digits in the correct position.";
        }
    }
}
