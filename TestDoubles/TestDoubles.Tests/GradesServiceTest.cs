using Moq;
using System.Collections.Generic;
using TestDoubles.Tests.Models;
using TestDoubles.Tests.Services;
using Xunit;

namespace TestDoubles.Tests
{
    public class GradesServiceTest
    {
        [Fact]
        public void AverageGradeCalculationShouldBeOk()
        {
            var student = new Student();
            var gradebookStub = new Mock<Gradebook>();
            gradebookStub.Setup(x => x.GradesFor(student)).Returns(new double[] { 8, 6, 10 });
            var service = new GradesService(gradebookStub.Object);

            double averageGrade = service.GetAverageGrade(student);

            Assert.Equal(8.0, averageGrade);
        }
    }
}
