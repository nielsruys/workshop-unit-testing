using DataDrivenTestExample;
using FluentAssertions;
using NUnit.Framework;

namespace Tests
{
    public class CalculatorTests
    {
        [Test]
        public void CanAdd()
        {
            var calculator = new Calculator();
            var value1 = 1;
            var value2 = 2;

            var result = calculator.Add(value1, value2);

            result.Should().Be(3);
        }

        [TestCase(1, 2, 3)]
        [TestCase(4, 6, 10)]
        [TestCase(2, 2, 4)]
        public void CanAddTheory(int value1, int value2, int expected)
        {
            var calculator = new Calculator();

            var result = calculator.Add(value1, value2);

            result.Should().Be(expected);
        }
    }
}