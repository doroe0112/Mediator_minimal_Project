using MediatorTest10.Rolladen;
using Microsoft.AspNetCore.Mvc;

namespace MediatorTest10.Controllers;


[Microsoft.AspNetCore.Components.Route("api/[controller]")]
[ApiController]
public class RolladenController:BaseController
{
    [HttpGet("status")]
    public async Task<IActionResult> GetStatus()
    {
        return Ok(await Mediator.Send(new RolladenHochCommand() { id = 3 }));
    }
}