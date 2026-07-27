namespace WarehouseApp.Application.Common.Models
{
    public class AuthenticationResponse
    {
        public string password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime Expiration { get; set; }
        public required string Token { get; set; }
    }
}
