using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieReminder.Api.Controllers;

[Route("api/auth")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register()
    {
        return NoContent();
    }

    [HttpPost("login")]
    public IActionResult Login()
    {
        return NoContent();
    }
}
