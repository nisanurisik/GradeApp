namespace Server.Entities.DTOs
{
  public sealed class CourseUpdateDto
  {
    public string CourseName { get; set; }
    public int Credits { get; set; }

    public int? TeacherId { get; set; }
    public int? DepartmentId { get; set; }
  }
}