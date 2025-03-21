using Microsoft.AspNetCore.Mvc;
using Server.Entities;
using Server.Services.Abstracts;

namespace Server.Controllers
{
  [ApiController]
  [Route("api/faculties")]
  public class FacultiesController : ControllerBase
  {
    private readonly IFacultyService _facultyService;

    public FacultiesController(IFacultyService facultyService)
    {
      _facultyService = facultyService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
      var faculties = await _facultyService.GetAllFacultiesAsync();
      return Ok(faculties);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
      var faculty = await _facultyService.GetByIdFaculty(id);
      return Ok(faculty);
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] Faculty faculty)
    {
      if (faculty == null || string.IsNullOrWhiteSpace(faculty.FacultyName))
      {
        return BadRequest(new { message = "Fakülte adı boş olamaz!" });
      }

      foreach (var department in faculty.Departments)
      {
        if (department.Faculty != null)
        {
          department.FacultyId = faculty.Id; // Faculty Id'yi Department'a elle atıyoruz.
          department.Faculty = null; // JSON parsing hatasını önlemek için
        }
      }

      await _facultyService.AddFacultyAsync(faculty);
      return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Faculty faculty)
    {
      await _facultyService.UpdateFacultyAsync(faculty);
      return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
      await _facultyService.DeleteFacultyAsync(id);
      return NoContent();
    }
  }
}