namespace Server.Entities.DTOs
{
  public class TeacherCreateDto
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Email { get; set; }
    public string Phone { get; set; }

    public int DepartmentId { get; set; }

    public Department Department { get; set; }
  }
}