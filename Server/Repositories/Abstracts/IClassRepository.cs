using Server.Entities;

namespace Server.Repositories.Abstracts
{
  public interface IClassRepository : IRepository<Class, int>
  {
    Task UpdateClassAsync(Class classes);
  }
}