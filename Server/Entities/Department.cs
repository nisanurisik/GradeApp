
using System.Text.Json.Serialization;

namespace Server.Entities
{
    public sealed class Department : Entity<int>
    {
        public string DepartmentName { get; set; }

        public int? FacultyId { get; set; }  // Foreign Key alanı

        [JsonIgnore]
        public Faculty? Faculty { get; set; }  // Navigation Property nullable
    }

}