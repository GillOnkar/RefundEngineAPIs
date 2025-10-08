using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RefundManagementAPI.Services;

namespace RefundManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IAuthService _authService;

        public TestController(IAuthService authService)
        {
            _authService = authService;
        }

        [Authorize]
        [HttpGet("secure")]
        public IActionResult Secure()
        {
            if (!_authService.IsAuthenticated(User))
                return Unauthorized();

            var userName = _authService.GetUserName(User);
            var userEmail = _authService.GetUserEmail(User);

            return Ok(new { Message = "You are authenticated!", User = userName, Email = userEmail });
        }
    }
}
