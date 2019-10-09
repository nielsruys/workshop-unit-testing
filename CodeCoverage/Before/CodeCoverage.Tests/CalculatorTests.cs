using Xunit;
using CodeCoverage;

namespace CodeCoverage.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(10, 5, 15)]
        [InlineData(1, 2, 3)]
        [InlineData(3, 4, 7)]
        public void Add_ShouldReturnTheSum(int value1, int value2, int expected)
        {
            var calculator = new Calculator();

            var actual = calculator.Add(value1, value2);

            Assert.Equal(expected, actual);
        }
    }
}