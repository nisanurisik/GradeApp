using Server.Entities.DTOs;

namespace Server.Services.Abstracts
{
  public interface ITeacherService
  {
    Task<IEnumerable<TeacherDto>> GetAllTeachersAsync();
    Task<TeacherDto> GetByIdTeacherAsync(int id);
    Task AddTeacherAsync(TeacherCreateDto teacherCreateDto);
    Task UpdateTeacherAsync(TeacherUpdateDto teacherUpdateDto);
    Task DeleteTeacherAsync(int id);
  }
}