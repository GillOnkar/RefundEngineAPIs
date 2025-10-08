using System.Security.Claims;

namespace RefundManagementAPI.Services
{
    public class AuthService : IAuthService
    {
        public string GetUserName(ClaimsPrincipal user)
        {
            return user.Identity?.Name ?? "Unknown User";
        }

        public string GetUserEmail(ClaimsPrincipal user)
        {
            return user.FindFirst("preferred_username")?.Value ?? "No Email";
        }

        public bool IsAuthenticated(ClaimsPrincipal user)
        {
            return user?.Identity?.IsAuthenticated ?? false;
        }
    }
}
