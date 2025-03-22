using Microsoft.AspNetCore.Http.HttpResults;
using Server.Entities;
using Server.Repositories.Abstracts;
using Server.Services.Abstracts;

namespace Server.Services.Concretes
{
  public class ClassService : IClassService
  {
    private readonly IClassRepository _classRepository;

    public ClassService(IClassRepository classRepository)
    {
      _classRepository = classRepository;
    }

    public async Task<IEnumerable<Class>> GetAllClassAsync()
    {
      var classes = await _classRepository.GetAllAsync();

      if (!classes.Any())
      {
        throw new Exception("Sınıf bulunamadı.");
      }

      return classes;
    }

    public async Task<Class> GetByIdClass(int id)
    {
      var cls = await _classRepository.GetByIdAsync(id);

      if (cls is null)
      {
        throw new Exception("Aradığınız sınıf bulunamadı.");
      }

      return cls;
    }

    public async Task AddClassAsync(Class classes)
    {
      if (classes.ClassLevel == 0)
      {
        throw new Exception("Sınıf boş bırakılamaz.");
      }

      await _classRepository.AddAsync(classes);
    }

    public async Task DeleteClassAsync(int id)
    {
      await _classRepository.DeleteAsync(id);
    }

    public async Task UpdateClassAsync(Class classes)
    {
      if (classes.ClassLevel == 0)
      {
        throw new Exception("Sınıf boş bırakılamaz.");
      }

      await _classRepository.UpdateClassAsync(classes);
    }
  }
}