using Server.Entities;
using Server.Repositories.Abstracts;
using Server.Repositories.Context;

namespace Server.Repositories.Concretes
{
  public class DepartmentRepository : Repository<Department, int>, IDepartmentRepository
  {
    private readonly AppDbContext _context;

    public DepartmentRepository(AppDbContext context) : base(context)
    {
      _context = context;
    }

    public async Task UpdateDepartmentAsync(Department department)
    {
      var updateDepartment = await GetByIdAsync(department.Id);

      if (department.Faculty != null)
      {
        updateDepartment.Faculty = department.Faculty;
      }

      updateDepartment.DepartmentName = department.DepartmentName;
      updateDepartment.FacultyId = department.FacultyId;

      await SaveAsync();
    }
  }
}