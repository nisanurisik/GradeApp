using Server.Entities.DTOs;

namespace Server.Services.Abstracts
{
  public interface ICourseService
  {
    Task<IEnumerable<CourseDto>> GetAllCoursesAsync();
    Task<CourseDto> GetByIdCourseAsync(int id);
    Task AddCourseAsync(CourseCreateDto courseCreateDto);
    Task UpdateCourseAsync(CourseUpdateDto courseUpdateDto);
    Task DeleteCourseAsync(int id);
  }
}