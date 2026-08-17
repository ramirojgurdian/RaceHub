using Microsoft.AspNetCore.Mvc;

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
    
    [HttpPost]
    public async Task<IActionResult> Add(RaceEvent race)
    {
        var result = await _repository.AddEvent(race);
        return Ok(result);
    }
}