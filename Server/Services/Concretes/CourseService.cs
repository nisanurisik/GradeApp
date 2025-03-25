using AutoMapper;
using Server.Entities;
using Server.Entities.DTOs;
using Server.Repositories.Abstracts;
using Server.Services.Abstracts;

namespace Server.Services.Concretes
{
  public class CourseService : ICourseService
  {
    private readonly ICourseRepository _courseRepository;
    private readonly IMapper _mapper;

    public CourseService(ICourseRepository courseRepository, IMapper mapper)
    {
      _courseRepository = courseRepository;
      _mapper = mapper;
    }

    public async Task<IEnumerable<CourseDto>> GetAllCoursesAsync()
    {
      var courses = await _courseRepository.GetAllAsync();

      if (!courses.Any())
      {
        throw new Exception("Ders bulunamadı.");
      }

      return _mapper.Map<IEnumerable<CourseDto>>(courses);
    }

    public async Task<CourseDto> GetByIdCourseAsync(int id)
    {
      var course = await _courseRepository.GetByIdAsync(id);

      if (course is null)
      {
        throw new Exception("Aradığınız ders bulunamadı.");
      }

      return _mapper.Map<CourseDto>(course);
    }
    public async Task AddCourseAsync(CourseCreateDto courseCreateDto)
    {
      var addCourse = _mapper.Map<Course>(courseCreateDto);

      if (string.IsNullOrWhiteSpace(addCourse.CourseName))
      {
        throw new Exception("Ders adı boş olamaz.");
      }

      await _courseRepository.AddAsync(addCourse);
    }

    public async Task DeleteCourseAsync(int id)
    {
      await _courseRepository.DeleteAsync(id);
    }

    public async Task UpdateCourseAsync(CourseUpdateDto courseUpdateDto)
    {
      var updateCourse = _mapper.Map<Course>(courseUpdateDto);

      if (string.IsNullOrWhiteSpace(updateCourse.CourseName))
      {
        throw new Exception("Ders adı boş olamaz.");
      }

      await _courseRepository.UpdateCourseAsync(updateCourse);
    }
  }
}