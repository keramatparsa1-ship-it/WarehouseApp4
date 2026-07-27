using MediatR;
using WarehouseApp.Application.Common.Interfaces;
using WarehouseApp.Application.Common.Models;

namespace WarehouseApp.Application.Features.Auth.Commands.Login
{

    public class LoginCommandHandler : IRequestHandler<LoginCommand, Common.Models.AuthenticationResponse?>
    {
        private readonly IIdentityService _identityService;

        public LoginCommandHandler(IIdentityService identityService)
        {
            _identityService = identityService;
        }


        public async Task<Common.Models.AuthenticationResponse?> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            
            return await _identityService.LoginAsync(request.Email, request.Password);
        }
    }
}
