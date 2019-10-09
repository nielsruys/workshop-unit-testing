using Xunit;

namespace BestPractices
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(5, 10, 15)]
        [InlineData(2, 1, 3)]
        [InlineData(8, 3, 11)]
        public void Add_ShouldReturnTheSum(int value1, int value2, int expected)
        {
            var calculator = new Calculator();

            var actual = calculator.Add(value1, value2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 10, -5)]
        [InlineData(2, 1, 1)]
        [InlineData(8, 3, 5)]
        public void Subtract_ShouldReturnTheDifference(int value1, int value2, int expected)
        {
            var calculator = new Calculator();

            var actual = calculator.Subtract(value1, value2);

            Assert.Equal(expected, actual);
        }
    }
}