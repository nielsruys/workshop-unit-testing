using System.Collections.Generic;
using System.Linq;

namespace TestDoubles.Tests.Models
{
    public class Gradebook
    {
        private readonly IList<Grade> _grades;

        public virtual double[] GradesFor(Student student)
        {
            return _grades.Where(g => g.StudentId == student.Id).Select(x => x.Value).ToArray();
        }
    }
}