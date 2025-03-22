using Server.Entities;
using Server.Repositories.Abstracts;
using Server.Repositories.Context;

namespace Server.Repositories.Concretes
{
  public class ClassRepository : Repository<Class, int>, IClassRepository
  {
    private readonly AppDbContext _context;

    public ClassRepository(AppDbContext context) : base(context)
    {
      _context = context;
    }

    public async Task UpdateClassAsync(Class classes)
    {
      var updateClass = await GetByIdAsync(classes.Id);
      updateClass.ClassLevel = classes.ClassLevel;

      await SaveAsync();
    }
  }
}