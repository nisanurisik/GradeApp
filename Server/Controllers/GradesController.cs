using Microsoft.AspNetCore.Mvc;
using Server.Entities;
using Server.Services.Abstracts;

namespace Server.Controllers
{
  [ApiController]
  [Route("api/grades")]
  public class GradesController : ControllerBase
  {
    private readonly IGradeService _gradeService;

    public GradesController(IGradeService gradeService)
    {
      _gradeService = gradeService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
      var grades = await _gradeService.GetAllGradesAsync();
      return Ok(grades);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
      var grade = await _gradeService.GetByIdGrade(id);
      return Ok(grade);
    }

    [HttpPost]
    public async Task<IActionResult> Add(GradeCreateDto gradeCreateDto)
    {
      await _gradeService.AddGradeAsync(gradeCreateDto);
      return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(GradeUpdateDto gradeUpdateDto)
    {
      await _gradeService.UpdateGradeAsync(gradeUpdateDto);
      return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
      await _gradeService.DeleteGradeAsync(id);
      return NoContent();
    }
  }
}