namespace BestPractices
{
    public class Calculator
    {
        public int Add(int value1, int value2)
        {
            return checked(value1 + value2);
        }

        public int Subtract(int value1, int value2)
        {
            return checked(value1 - value2);
        }
    }
}
