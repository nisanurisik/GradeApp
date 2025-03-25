namespace Server.Entities
{
  public class StudentUpdateDto
  {
    public int Id { get; set; }
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
  }
}