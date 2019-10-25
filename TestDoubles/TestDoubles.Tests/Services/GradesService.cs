using System.Linq;
using TestDoubles.Tests.Models;

namespace TestDoubles.Tests.Services
{
    public class GradesService
    {
        private readonly Gradebook gradebook;
    
        public GradesService(Gradebook gradebook)
        {
            this.gradebook = gradebook;
        }

        public double GetAverageGrade(Student student)
        {
            return gradebook.GradesFor(student).Average();
        }
    }
}
