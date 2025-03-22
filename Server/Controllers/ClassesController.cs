using Microsoft.AspNetCore.Mvc;
using Server.Entities;
using Server.Services.Abstracts;

namespace Server.Controllers
{
  [ApiController]
  [Route("api/classes")]
  public class ClassesController : ControllerBase
  {
    private IClassService _classService;

    public ClassesController(IClassService classService)
    {
      _classService = classService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
      var classes = await _classService.GetAllClassAsync();
      return Ok(classes);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
      var cls = await _classService.GetByIdClass(id);
      return Ok(cls);
    }

    [HttpPost]
    public async Task<IActionResult> Add(Class classes)
    {
      await _classService.AddClassAsync(classes);
      return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Class classes)
    {
      await _classService.UpdateClassAsync(classes);
      return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
      await _classService.DeleteClassAsync(id);
      return NoContent();
    }
  }
}