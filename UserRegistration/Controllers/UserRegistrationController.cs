using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BusinessLayer.Interface;
using ModelLayer.DTO;

namespace UserRegistration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        private readonly IUserRegistrationBL _userRegistrationBL;
        private readonly ILogger<UserRegistrationController> _logger;

        public UserRegistrationController(IUserRegistrationBL userRegistrationBL, ILogger<UserRegistrationController> logger)
        {
            _userRegistrationBL = userRegistrationBL;
            _logger = logger;
        }

        [HttpGet]
        public string registrationGet()
        {
            return _userRegistrationBL.registrationBL("Value from controller");
        }

        [HttpPost]
        public IActionResult RegisterUser(RegisterDTO user)
        {
            var response = new ResponseDTO<string>();
            try
            {
                bool result = _userRegistrationBL.RegisterUser(user);
                if (result)
                {
                    response.Success = true;
                    response.Message = "User registered successfully";
                    response.Data = user.Password;
                    return Ok(response);
                }
                response.Success = false;
                response.Message = "Email already exists";
                return BadRequest(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Controller Layer");
                response.Success = false;
                response.Message = "An error occurred";
                response.Data = ex.Message;
                return BadRequest(response);
            }
        }
    }
}