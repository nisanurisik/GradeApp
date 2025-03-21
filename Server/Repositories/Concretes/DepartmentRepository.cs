using Server.Entities;
using Server.Repositories.Abstracts;
using Server.Repositories.Context;

namespace Server.Repositories.Concretes
{
  public class DepartmentRepository : Repository<Department, int>, IDepartmentRepository
  {
    private readonly AppDbContext _context;

    public DepartmentRepository(AppDbContext context) : base(context, context.Set<Department>())
    {
      _context = context;
    }

    public async Task UpdateDepartmentAsync(Department department)
    {
      var updateDepartment = await GetByIdAsync(department.Id);
      updateDepartment.DepartmentName = department.DepartmentName;

      _context.Departments.Update(department);
      await SaveAsync();
    }
  }
}