using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class RaceEventController(IRaceEventRepository repository) : ControllerBase
{
    IRaceEventRepository _repository = repository;
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _repository.GetAllEvents();
        return Ok(result);
    }
}