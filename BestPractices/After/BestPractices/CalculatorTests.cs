using FluentAssertions;
using System;
using Xunit;
using Xunit.Abstractions;

namespace BestPractices
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(5, 10, 15)]
        [InlineData(2, 5, 7)]
        [InlineData(int.MinValue, int.MaxValue, -1)]
        [InlineData(int.MaxValue, int.MinValue, -1)]
        public void Add_ShouldReturnTheSum(int value1, int value2, int expected)
        {
            var calculator = new Calculator();

            var actual = calculator.Add(value1, value2);

            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(int.MinValue, -1)]
        [InlineData(-1, int.MinValue)]
        [InlineData(int.MaxValue, 1)]
        [InlineData(1, int.MaxValue)]
        public void Add_WithExtremeValues_ShouldThrowOverFlowException(int value1, int value2)
        {
            var calculator = new Calculator();

            Action action = () => calculator.Add(value1, value2);

            action.Should().Throw<OverflowException>();
        }

        [Theory]
        [InlineData(5, 10, -5)]
        [InlineData(2, 5, -3)]
        [InlineData(int.MinValue, int.MinValue, 0)]
        [InlineData(int.MaxValue, int.MaxValue, 0)]
        public void Subtract_ShouldReturnTheDifference(int value1, int value2, int expected)
        {
            var calculator = new Calculator();

            var actual = calculator.Subtract(value1, value2);

            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(int.MinValue, 1)]
        [InlineData(1, int.MinValue)]
        [InlineData(-2, int.MaxValue)]
        [InlineData(int.MaxValue, -1)]
        public void Subtract_WithExtremeValues_ShouldThrowOverFlowException(int value1, int value2)
        {
            var calculator = new Calculator();

            Action action = () => calculator.Subtract(value1, value2);

            action.Should().Throw<OverflowException>();
        }
    }
}