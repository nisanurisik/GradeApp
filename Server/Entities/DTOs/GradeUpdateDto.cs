namespace Server.Entities
{
  public class GradeUpdateDto
  {
    public int Id { get; set; }
    public int Midterm { get; set; }
    public int FinalExam { get; set; }
    public int Quiz { get; set; }

    public int StudentId { get; set; }
    public int CourseId { get; set; }
  }
}