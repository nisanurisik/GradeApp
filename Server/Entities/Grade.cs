
namespace Server.Entities
{
    public sealed class Grade : Entity<int>
    {
        public int Midterm { get; set; }
        public int FinalExam { get; set; }
        public int Quiz { get; set; }

        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public Student? Student { get; set; }
        public Course? Course { get; set; }
    }
}