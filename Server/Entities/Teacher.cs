namespace Server.Entities
{
    public sealed class Teacher : Entity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public int DepartmentId { get; set; }

        public Department? Department { get; set; }

        public ICollection<Course>? Courses { get; set; } = new List<Course>();
    }
}