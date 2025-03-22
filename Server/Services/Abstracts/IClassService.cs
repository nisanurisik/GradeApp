using Server.Entities;

namespace Server.Services.Abstracts
{
  public interface IClassService
  {
    Task<IEnumerable<Class>> GetAllClassAsync();
    Task<Class> GetByIdClass(int id);
    Task AddClassAsync(Class classes);
    Task UpdateClassAsync(Class classes);
    Task DeleteClassAsync(int id);
  }
}