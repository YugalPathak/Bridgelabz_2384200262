using Microsoft.Extensions.Logging;
using ModelLayer.DTO;
using RepositoryLayer.Interface;

namespace RepositoryLayer.Service
{
    public class UserRegistrationRL : IUserRegistrationRL
    {
        private string databaseEmail = "Yugal@gmail.com";
        private string databasePassword = "123";
        private readonly ILogger<UserRegistrationRL> _logger;

        public UserRegistrationRL(ILogger<UserRegistrationRL> logger)
        {
            _logger = logger;
        }

        public string registrationRL(string name)
        {
            try
            {
                return name + " Hello from Repository Layer";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Repository Layer");
                return "Error occurred";
            }
        }

        public RegisterDTO GetUserByEmail(string Email)
        {
            try
            {
                if (Email == databaseEmail)
                {
                    return new RegisterDTO
                    {
                        FirstName = "Yugal",
                        LastName = "Pathak",
                        Email = databaseEmail,
                        Password = databasePassword
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Repository Layer");
                return null;
            }
        }

        public bool RegisterUser(RegisterDTO user)
        {
            try
            {
                if (user.Email == databaseEmail)
                {
                    return false;
                }
                databaseEmail = user.Email;
                databasePassword = user.Password;
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Repository Layer");
                return false;
            }
        }
    }
}
