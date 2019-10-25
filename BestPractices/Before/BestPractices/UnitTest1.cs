using System;
using Xunit;

namespace BestPractices
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var a = 10;
            var b = 5;
            var c = new Calculator();

            var d = c.Add(a, b);
            var e = c.Subtract(b, a);

            Assert.Equal(15, d);
            Assert.Equal(-5, e);
        }
    }
}
