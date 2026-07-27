using MediatR;
using Microsoft.AspNetCore.Mvc;
using WarehouseApp.Application.Features.Auth.Commands.Login;
using WarehouseApp.Application.Users.Commands.RegisterUser;

namespace WarehouseApp.WebApi.Controllers.V1;
[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IMediator _mediator;

    public AuthController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterUserCommand command)
    {
            var result = await _mediator.Send(command);

        if (result)
        {
            return Ok(new { message = "User registered successfully!" });
        }

        return BadRequest(new { message = "Registration failed. Please check your input." });
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginCommand command)
    {
        var result = await _mediator.Send(command);

        if (result == null)
        {
            return Unauthorized(new { message = "Invalid email or password." });
        }

        return Ok(result);
    }

}
