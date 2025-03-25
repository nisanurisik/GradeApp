using Server.Entities;
using Server.Entities.DTOs;

namespace Server.Repositories.Abstracts
{
  public interface ICourseRepository : IRepository<Course, int>
  {
    Task UpdateCourseAsync(Course course);
  }
}