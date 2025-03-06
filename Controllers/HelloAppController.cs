using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Service;
using ModelLayer.DTO;
using BusinessLayer.Interface;
using NLog;

namespace HelloApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloAppController : ControllerBase
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly IRegistrationHelloBL _registerHelloBL;
        private readonly RedisCacheService _cacheService;
        ResponseModel<string> response;

        public HelloAppController(IRegistrationHelloBL registerHelloBL, RedisCacheService cacheService)
        {
            _registerHelloBL = registerHelloBL;
            _cacheService = cacheService;
        }

        [HttpGet("cache")]
        public async Task<IActionResult> GetCachedData()
        {
            var cachedData = await _cacheService.GetCacheAsync<string>("testKey");
            if (cachedData == null)
            {
                await _cacheService.SetCacheAsync("testKey", "Hello from Redis!", 10);
                return Ok("Data set in cache!");
            }
            return Ok(cachedData);
        }

        [HttpGet]
        public string Get()
        {
            logger.Info("Get method called");
            return _registerHelloBL.registration("value from controller");
        }

        [HttpPost]
        public IActionResult LoginUser(LoginDTO loginDTO)
        {
            try
            {
                logger.Info("LoginUser method called");
                response = new ResponseModel<string>();
                bool result = _registerHelloBL.loginUser(loginDTO);

                if (result)
                {
                    response.Success = true;
                    response.Message = "Login Successful";
                    response.Data = loginDTO.username;
                    logger.Info("Login successful for user: {0}", loginDTO.username);
                    return Ok(response);
                }

                response.Success = false;
                response.Message = "Login failed";
                response.Data = "";
                logger.Warn("Login failed for user: {0}", loginDTO.username);
                return NotFound(response);
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Login failed";
                response.Data = ex.Message;
                logger.Error(ex, "Exception in LoginUser method");
                return BadRequest(response);
            }
        }

        [HttpPost]
        [Route("register")]
        public IActionResult RegistrationUser(RegisterDTO registerDTO)
        {
            try
            {
                logger.Info("RegistrationUser method called");
                var result = _registerHelloBL.registerBL(registerDTO);
                response = new ResponseModel<string>
                {
                    Success = true,
                    Message = "User registered successfully",
                    Data = ""
                };
                logger.Info("User registered successfully: {0}", registerDTO.FirstName);
                return Created("User Created", result);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in RegistrationUser method");
                response = new ResponseModel<string>
                {
                    Success = false,
                    Message = "User registration failed",
                    Data = ex.Message
                };
                return BadRequest(response);
            }
        }
    }
}
