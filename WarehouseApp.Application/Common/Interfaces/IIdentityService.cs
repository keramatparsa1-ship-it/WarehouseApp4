using WarehouseApp.Application.Common.Models;

namespace WarehouseApp.Application.Common.Interfaces
{
    public interface IIdentityService
    {
        Task<AuthenticationResponse?> LoginAsync(string email, string password);
        Task<bool> RegisterAsync(string email, string password);
    }

}
