using Server.Entities;

namespace Server.Repositories.Abstracts
{
  public interface IDepartmentRepository : IRepository<Department, int>
  {
    Task UpdateDepartmentAsync(Department department);
  }
}