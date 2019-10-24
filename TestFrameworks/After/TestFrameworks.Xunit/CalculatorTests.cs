using Xunit;

namespace TestFrameworks.Xunit
{
    public class CalculatorTests
    {
        [Fact(Skip = "for demo purposes"), Trait("category", "Default")]
        public void CanAdd()
        {
            var calculator = new Calculator();
            var value1 = 1;
            var value2 = 2;

            var result = calculator.Add(value1, value2);

            Assert.Equal(3, result);
        }

        [Theory, Trait("category", "DataDriven")]
        [InlineData(1, 2, 3)]
        [InlineData(4, 6, 10)]
        [InlineData(2, 2, 4)]
        public void CanAddTheory(int value1, int value2, int expected)
        {
            var calculator = new Calculator();

            var result = calculator.Add(value1, value2);

            Assert.Equal(expected, result);
        }
    }
}
