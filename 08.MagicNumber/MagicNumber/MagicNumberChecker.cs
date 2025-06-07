using System;

namespace MagicNumber
{
    public class MagicNumberChecker
    {
        public bool IsMagicNumber(int number)
        {
            if (number <= 0)
                return false;

            return number % 3 == 0 && number.ToString().Contains('3');
        }
    }
}