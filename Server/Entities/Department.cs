
namespace Server.Entities
{
    public sealed class Department : Entity<int>
    {
        public string DepartmentName { get; set; }

        public int? FacultyId { get; set; }
        public Faculty Faculty { get; set; }
    }
}