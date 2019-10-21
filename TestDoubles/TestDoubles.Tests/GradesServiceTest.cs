using Moq;
using System.Collections.Generic;
using TestDoubles.Tests.Models;
using TestDoubles.Tests.Services;
using Xunit;

namespace TestDoubles.Tests
{
    public class GradesServiceTest
    {
        private readonly Student _student;
        private readonly Mock<Gradebook> _gradebookStub;

        public GradesServiceTest()
        {
            _gradebookStub = new Mock<Gradebook>();
            _student = new Student();
        }

        [Fact]
        public void AverageGradeCalculationShouldBeOk()
        {
            _gradebookStub.Setup(x => x.GradesFor(_student)).Returns(new double[] { 8, 6, 10 });

            double averageGrades = new GradesService(_gradebookStub.Object).GetAverageGrades(_student);

            Assert.Equal(8.0, averageGrades);
        }
    }
}
