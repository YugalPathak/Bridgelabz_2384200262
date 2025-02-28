using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Service;
using ModelLayer.DTO;
using System.Linq.Expressions;

namespace UserRegistration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        UserRegistrationBL _userRegistrationBL;
        ResponseDTO<String> response;
        public UserRegistrationController(UserRegistrationBL userRegistrationBL) 
        {
            _userRegistrationBL = userRegistrationBL;
        }
        [HttpGet]
        public string registrationGet()
        {
            return _userRegistrationBL.registrationBL("Value from controller");
        }

        [HttpPost]

        public IActionResult RegisterUser(RegisterDTO user)
        {
            try
            {
                response = new ResponseDTO<String>();

                bool result = _userRegistrationBL.RegisterUser(user);

                if (result)
                {
                    response.Success = true;
                    response.Message = "User registered successfully";
                    response.Data = user.Password;
                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Email already exist";
                response.Data = ex.Message;
                
            }
            return BadRequest(response);
        }
    }
}

           



