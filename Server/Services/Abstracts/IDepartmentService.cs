using Server.Entities;

namespace Server.Services.Abstracts
{
  public interface IDepartmentService
  {
    Task<IEnumerable<Department>> GetAllDepartmentsAsync();
    Task<Department> GetByIdDepartmentAsync(int id);
    Task AddDepartmentAsync(Department department);
    Task UpdateDepartmentAsync(Department department);
    Task DeleteDepartmentAsync(int id);
  }
}