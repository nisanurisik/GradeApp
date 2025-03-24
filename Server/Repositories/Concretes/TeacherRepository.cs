using Server.Entities;
using Server.Repositories.Abstracts;
using Server.Repositories.Context;

namespace Server.Repositories.Concretes
{
  public class TeacherRepository : Repository<Teacher, int>, ITeacherRepository
  {
    private readonly AppDbContext _context;

    public TeacherRepository(AppDbContext context) : base(context)
    {
      _context = context;
    }

    public async Task UpdateTeacherAsync(Teacher teacher)
    {
      var updateTeacher = await GetByIdAsync(teacher.Id);

      updateTeacher.FirstName = teacher.FirstName;
      updateTeacher.LastName = teacher.LastName;
      updateTeacher.Email = teacher.Email;
      updateTeacher.Phone = teacher.Phone;
      updateTeacher.DepartmentId = teacher.DepartmentId;

      await SaveAsync();
    }
  }
}