using ModelLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;

namespace RepositoryLayer.Service
{
    public class UserRegistrationRL
    {
        private string databaseEmail = "Yugal@gmail.com";
        private string databasePassword = "123";
        public UserRegistrationRL() 
        {
        }

        public string registrationRL(string name)
        {
            return name + " Hello from Repository Layer" ;
        }

        public RegisterDTO GetUserByEmail(string Email)
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

        public bool RegisterUser(RegisterDTO user)
        {
            if (user.Email == databaseEmail)
            {
                return false; 
            }

            databaseEmail = user.Email;
            databasePassword = user.Password;
            return true;
        }
    }
}
