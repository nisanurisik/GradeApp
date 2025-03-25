using Microsoft.AspNetCore.Mvc;
using Server.Entities.DTOs;
using Server.Services.Abstracts;

namespace Server.Controllers
{
  [ApiController]
  [Route("api/teachers")]
  public class TeachersController : ControllerBase
  {
    private readonly ITeacherService _teacherService;

    public TeachersController(ITeacherService teacherService)
    {
      _teacherService = teacherService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
      var teachers = await _teacherService.GetAllTeachersAsync();
      return Ok(teachers);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
      var teacher = await _teacherService.GetByIdTeacherAsync(id);
      return Ok(teacher);
    }

    [HttpPost]
    public async Task<IActionResult> Add(TeacherCreateDto teacherCreateDto)
    {
      await _teacherService.AddTeacherAsync(teacherCreateDto);
      return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(TeacherUpdateDto teacherUpdateDto)
    {
      await _teacherService.UpdateTeacherAsync(teacherUpdateDto);
      return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
      await _teacherService.DeleteTeacherAsync(id);
      return NoContent();
    }
  }
}