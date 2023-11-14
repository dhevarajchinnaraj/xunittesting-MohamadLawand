using Microsoft.AspNetCore.Mvc;

namespace FormulaApp.Api;

[ApiController]
[Route("api/[controller]")]
public class FansController : ControllerBase
{
	[HttpGet(Name = "GetFans")]
	public async Task<IActionResult> Get()
	{
		return Ok("Fans");
	}
}
