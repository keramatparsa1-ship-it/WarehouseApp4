using MediatR;

namespace WarehouseApp.Application.Users.Commands.RegisterUser;

public record RegisterUserCommand(
string UserName,
string Email,
string Password,
string FirstName,
string LastName) : IRequest<bool>;

