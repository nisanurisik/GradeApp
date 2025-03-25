using Microsoft.AspNetCore.Mvc;
using Server.Entities;
using Server.Services.Abstracts;

namespace Server.Controllers
{
  [ApiController]
  [Route("api/students")]
  public class StudentsController : ControllerBase
  {
    private readonly IStudentService _studentService;

    public StudentsController(IStudentService studentService)
    {
      _studentService = studentService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
      var students = await _studentService.GetAllStudentsAsync();
      return Ok(students);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
      var student = await _studentService.GetByIdStudentAsync(id);
      return Ok(student);
    }

    [HttpPost]
    public async Task<IActionResult> Add(StudentCreateDTO studentCreateDTO)
    {
      await _studentService.AddStudentAsync(studentCreateDTO);
      return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(StudentUpdateDto studentUpdateDto)
    {
      await _studentService.UpdateStudentAsync(studentUpdateDto);
      return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
      await _studentService.DeleteStudentAsync(id);
      return NoContent();
    }
  }
}