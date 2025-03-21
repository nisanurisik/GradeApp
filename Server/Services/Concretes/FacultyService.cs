using Server.Entities;
using Server.Repositories.Abstracts;
using Server.Services.Abstracts;

namespace Server.Services.Concretes
{
  public class FacultyService : IFacultyService
  {
    private readonly IFacultyRepository _facultyRepository;

    public FacultyService(IFacultyRepository facultyRepository)
    {
      _facultyRepository = facultyRepository;
    }

    public async Task<IEnumerable<Faculty>> GetAllFacultiesAsync()
    {
      var faculties = await _facultyRepository.GetAllAsync();

      if (!faculties.Any())
      {
        throw new Exception("Fakülte bulunamadı!");
      }

      return faculties;
    }

    public async Task<Faculty> GetByIdFaculty(int id)
    {
      var faculty = await _facultyRepository.GetByIdAsync(id);

      if (faculty is null)
      {
        throw new Exception("Aradığınız fakülte bulunamadı.");
      }

      return faculty;
    }

    public async Task AddFacultyAsync(Faculty faculty)
    {

      if (string.IsNullOrWhiteSpace(faculty.FacultyName))
      {
        throw new Exception("Fakülte adı boş bırakılamaz.");
      }

      await _facultyRepository.AddAsync(faculty);
    }

    public async Task DeleteFacultyAsync(int id)
    {
      await _facultyRepository.DeleteAsync(id);
    }

    public async Task UpdateFacultyAsync(Faculty faculty)
    {

      if (string.IsNullOrWhiteSpace(faculty.FacultyName))
      {
        throw new Exception("Fakülte adı boş bırakılamaz.");
      }

      await _facultyRepository.UpdateFacultyAsync(faculty);
    }
  }
}