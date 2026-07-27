using MediatR;

namespace WarehouseApp.Application.Users.Queries;

public record GetUsersQuery() : IRequest<List<string>>;
