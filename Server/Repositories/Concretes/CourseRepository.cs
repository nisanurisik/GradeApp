using Server.Entities;
using Server.Repositories.Abstracts;
using Server.Repositories.Context;

namespace Server.Repositories.Concretes
{
  public class CourseRepository : Repository<Course, int>, ICourseRepository
  {
    private readonly AppDbContext _context;

    public CourseRepository(AppDbContext context) : base(context)
    {
      _context = context;
    }

    public async Task UpdateCourseAsync(Course course)
    {
      var updateCourse = await GetByIdAsync(course.Id);

      updateCourse.CourseName = course.CourseName;
      updateCourse.Credits = course.Credits;
      updateCourse.DepartmentId = course.DepartmentId;
      updateCourse.TeacherId = course.TeacherId;

      await SaveAsync();
    }
  }
}