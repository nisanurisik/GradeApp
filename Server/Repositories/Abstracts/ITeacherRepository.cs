using Server.Entities;

namespace Server.Repositories.Abstracts
{
  public interface ITeacherRepository : IRepository<Teacher, int>
  {
    Task UpdateTeacherAsync(Teacher teacher);
  }
}