using Server.Entities;
using Server.Entities.DTOs;

namespace Server.Services.Abstracts
{
  public interface IStudentService
  {
    Task<IEnumerable<StudentDto>> GetAllStudentsAsync();
    Task<StudentDto> GetByIdStudentAsync(int id);
    Task AddStudentAsync(StudentCreateDTO studentCreateDTO);
    Task UpdateStudentAsync(StudentUpdateDto studentUpdateDto);
    Task DeleteStudentAsync(int id);
  }
}