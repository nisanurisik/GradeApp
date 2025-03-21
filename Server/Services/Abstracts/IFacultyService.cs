using Server.Entities;

namespace Server.Services.Abstracts
{
  public interface IFacultyService
  {
    Task<IEnumerable<Faculty>> GetAllFacultiesAsync();
    Task<Faculty> GetByIdFaculty(int id);
    Task AddFacultyAsync(Faculty faculty);
    Task UpdateFacultyAsync(Faculty faculty);
    Task DeleteFacultyAsync(int id);

  }
}