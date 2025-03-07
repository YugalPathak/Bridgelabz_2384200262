using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.DTO;
using static BusinessLayer.Service.ResetPasswordBL;

namespace UserRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResetController : ControllerBase
    {
        private readonly UserService _userService;

        public ResetController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("forgot-password")]
        public IActionResult ForgotPassword([FromBody] ForgotRequest request)
        {
            var token = _userService.RequestPasswordReset(request.Email);
            if (token == null)
                return BadRequest("User not found.");

            // TODO: Send the token via email
            return Ok(new { message = "Reset token generated. Check your email." });
        }

        [HttpPost("reset-password")]
        public IActionResult ResetPassword([FromBody] ResetRequest request)
        {
            var success = _userService.UpdatePassword(request.Token, request.NewPassword);
            if (!success)
                return BadRequest("Invalid or expired token.");

            return Ok(new { message = "Password reset successful." });
        }
    }
}
