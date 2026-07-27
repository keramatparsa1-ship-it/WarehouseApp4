using MediatR;
using Microsoft.AspNetCore.Mvc;
using WarehouseApp.Application.Users.Queries;

namespace WarehouseApp.WebApi.Controllers.V1;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;

    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        var users = await _mediator.Send(new GetUsersQuery());
        return Ok(users);
    }
}
