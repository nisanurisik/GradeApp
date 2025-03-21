
namespace Server.Entities
{
    public sealed class Faculty : Entity<int>
    {
        public string FacultyName { get; set; }

        public ICollection<Department>? Departments { get; set; } = new List<Department>();
    }
}