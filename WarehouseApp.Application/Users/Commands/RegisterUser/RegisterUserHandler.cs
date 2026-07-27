using MediatR;
using Microsoft.AspNetCore.Identity;
using WarehouseApp.Domain.Entities;


namespace WarehouseApp.Application.Users.Commands.RegisterUser;
public class RegisterUserHandler : IRequestHandler<RegisterUserCommand, bool>
{
    private readonly UserManager<ApplicationUser> _userManager;

    public RegisterUserHandler(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<bool> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
    {
        var user = new ApplicationUser
        {
            UserName = request.UserName,
            Email = request.Email,
            Password = request.Password,
            FirstName = request.FirstName,
            LastName = request.LastName
        };

       
        var result = await _userManager.CreateAsync(user, request.Password);

        return result.Succeeded;
    }
}