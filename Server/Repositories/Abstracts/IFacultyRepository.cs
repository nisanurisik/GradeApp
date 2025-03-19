using Server.Entities;

namespace Server.Repositories.Abstracts
{
  public interface IFacultyRepository : IRepository<Faculty, int>
  {
    Task UpdateFacultyAsync(Faculty faculty);
  }
}