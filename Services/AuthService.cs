using System.Security.Claims;

namespace RefundManagementAPI.Services
{
    public interface IAuthService
    {
        string GetUserName(ClaimsPrincipal user);
        string GetUserEmail(ClaimsPrincipal user);
        bool IsAuthenticated(ClaimsPrincipal user);
    }
}