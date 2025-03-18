namespace Server.Entities
{
    public sealed class Student : Entity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public char Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string StudentNumber { get; set; }

        public int? ClassId { get; set; }
        public int? DepartmentId { get; set; }

        public Class Class { get; set; }
        public Department Department { get; set; }

        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
    }
}