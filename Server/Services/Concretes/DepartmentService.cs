using Server.Entities;
using Server.Repositories.Abstracts;

namespace Server.Services.Abstracts
{
  public class DepartmentService : IDepartmentService
  {
    private readonly IDepartmentRepository _departmentRepository;

    public DepartmentService(IDepartmentRepository departmentRepository)
    {
      _departmentRepository = departmentRepository;
    }

    public async Task<IEnumerable<Department>> GetAllDepartmentsAsync()
    {
      var departments = await _departmentRepository.GetAllAsync();

      if (!departments.Any())
      {
        throw new Exception("Departman bulunamadı.");
      }

      return departments;
    }

    public async Task<Department> GetByIdDepartmentAsync(int id)
    {
      var department = await _departmentRepository.GetByIdAsync(id);

      if (department is null)
      {
        throw new Exception("Aradığınız depaartman bulunamadı");
      }

      return department;
    }
    public async Task AddDepartmentAsync(Department department)
    {
      if (!string.IsNullOrWhiteSpace(department.DepartmentName))
      {
        throw new Exception("Departman adı boş olamaz.");
      }

      await _departmentRepository.AddAsync(department);
    }

    public async Task DeleteDepartmentAsync(int id)
    {
      await _departmentRepository.DeleteAsync(id);
    }

    public async Task UpdateDepartmentAsync(Department department)
    {
      if (!string.IsNullOrWhiteSpace(department.DepartmentName))
      {
        throw new Exception("Departman adı boş bırakılamaz.");
      }

      await _departmentRepository.UpdateDepartmentAsync(department);
    }
  }
}