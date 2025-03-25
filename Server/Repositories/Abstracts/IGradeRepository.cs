using Server.Entities;

namespace Server.Repositories.Abstracts
{
  public interface IGradeRepository : IRepository<Grade, int>
  {
    Task UpdateGradeAsync(Grade grade);
  }
}