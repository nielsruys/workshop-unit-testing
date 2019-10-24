using NUnit.Framework;

namespace TestFrameworks.Nunit
{
    public class CalculatorTests
    {
        [Test, Ignore("for demo purposes"), Category("Default")]
        public void CanAdd()
        {
            var calculator = new Calculator();
            var value1 = 1;
            var value2 = 2;

            var result = calculator.Add(value1, value2);

            Assert.AreEqual(3, result);
        }

        [Category("DataDriven")]
        [TestCase(1, 2, 3)]
        [TestCase(4, 6, 10)]
        [TestCase(2, 2, 4)]
        public void CanAddTheory(int value1, int value2, int expected)
        {
            var calculator = new Calculator();

            var result = calculator.Add(value1, value2);

            Assert.AreEqual(expected, result);
        }
    }
}