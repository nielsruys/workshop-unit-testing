using System;

namespace CodeCoverage
{
    public class Calculator
    {
        public int Add(int value1, int value2)
        {
            if (value1 < 0)
                throw new ArgumentOutOfRangeException(nameof(value1), "Negative value");
            if (value2 < 0)
                throw new ArgumentOutOfRangeException(nameof(value2), "Negative value");

            return checked(value1 + value2);
        }
    }
}
