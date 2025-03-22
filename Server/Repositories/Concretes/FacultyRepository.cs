using Server.Entities;
using Server.Repositories.Abstracts;
using Server.Repositories.Context;

namespace Server.Repositories.Concretes
{
  public class FacultyRepository : Repository<Faculty, int>, IFacultyRepository
  {
    private readonly AppDbContext _context;

    public FacultyRepository(AppDbContext context) : base(context)
    {
      _context = context;
    }

    public async Task UpdateFacultyAsync(Faculty faculty)
    {
      var updateFaculty = await GetByIdAsync(faculty.Id);
      updateFaculty.FacultyName = updateFaculty.FacultyName;

      await SaveAsync();
    }
  }
}
