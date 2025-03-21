using Microsoft.AspNetCore.Mvc;
using Server.Entities;
using Server.Services.Abstracts;

namespace Server.Controllers
{
  [ApiController]
  [Route("api/departments")]
  public class DepartmentsController : ControllerBase
  {

    private readonly IDepartmentService _departmentService;

    public DepartmentsController(IDepartmentService departmentService)
    {
      _departmentService = departmentService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
      var departments = await _departmentService.GetAllDepartmentsAsync();
      return Ok(departments);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
      var department = await _departmentService.GetByIdDepartmentAsync(id);
      return Ok(department);
    }

    [HttpPost]
    public async Task<IActionResult> Add(Department department)
    {
      await _departmentService.AddDepartmentAsync(department);
      return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Department department)
    {
      await _departmentService.UpdateDepartmentAsync(department);
      return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
      await _departmentService.DeleteDepartmentAsync(id);
      return NoContent();
    }
  }
}