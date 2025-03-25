using Server.Entities;

namespace Server.Repositories.Abstracts
{
  public interface IStudentRepository : IRepository<Student, int>
  {
    Task UpdateStudentAsync(Student student);
  }
}