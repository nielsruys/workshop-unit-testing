namespace TestDoubles.Tests.Models
{
    public class Grade
    {
        public Grade(int studentId, double value)
        {
            StudentId = studentId;
            Value = value;
        }

        public double Value { get; private set; }
        public int StudentId { get; private set; }
    }
}