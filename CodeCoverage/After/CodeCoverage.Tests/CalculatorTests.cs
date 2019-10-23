using System;
using Xunit;

namespace CodeCoverage.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(10, 5, 15)]
        [InlineData(1, 2, 3)]
        public void Add_ShouldReturnTheSum(int value1, int value2, int expected)
        {
            var calculator = new Calculator();

            var actual = calculator.Add(value1, value2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_ShouldThrowWithNegativeValue1()
        {
            var value1 = -2;
            var value2 = 1;
            var calculator = new Calculator();

            void Action() => calculator.Add(value1, value2);
            Assert.Throws<ArgumentOutOfRangeException>(Action);
        }

        [Fact]
        public void Add_ShouldThrowWithNegativeValue2()
        {
            var value1 = 2;
            var value2 = -1;
            var calculator = new Calculator();

            void Action() => calculator.Add(value1, value2);
            Assert.Throws<ArgumentOutOfRangeException>(Action);
        }
    }
}