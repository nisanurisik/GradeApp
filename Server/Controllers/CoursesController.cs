using Microsoft.AspNetCore.Mvc;
using Server.Entities.DTOs;
using Server.Services.Abstracts;

namespace Server.Controllers
{
  [ApiController]
  [Route("api/courses")]
  public class CoursesController : ControllerBase
  {
    private readonly ICourseService _courseService;

    public CoursesController(ICourseService courseService)
    {
      _courseService = courseService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
      var courses = await _courseService.GetAllCoursesAsync();
      return Ok(courses);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
      var course = await _courseService.GetByIdCourseAsync(id);
      return Ok(course);
    }

    [HttpPost]
    public async Task<IActionResult> Add(CourseCreateDto courseCreateDto)
    {
      await _courseService.AddCourseAsync(courseCreateDto);
      return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(CourseUpdateDto courseUpdateDto)
    {
      await _courseService.UpdateCourseAsync(courseUpdateDto);
      return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
      await _courseService.DeleteCourseAsync(id);
      return NoContent();
    }
  }
}