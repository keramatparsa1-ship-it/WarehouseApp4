using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WarehouseApp.Domain.Entities;

namespace WarehouseApp.Application.Users.Queries;

public class GetUsersHandler : IRequestHandler<GetUsersQuery, List<string>>
{
    private readonly UserManager<ApplicationUser> _userManager;

    public GetUsersHandler(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<List<string>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        
        var users = await _userManager.Users.ToListAsync(cancellationToken);

        return users.Select(u => u.Email ?? "No Email").ToList();
    }
}
