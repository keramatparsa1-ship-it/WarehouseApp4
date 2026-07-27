using MediatR;
using WarehouseApp.Application.Common.Models;

namespace WarehouseApp.Application.Features.Auth.Commands.Login
{

    public class LoginCommand : IRequest<AuthenticationResponse?>
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
