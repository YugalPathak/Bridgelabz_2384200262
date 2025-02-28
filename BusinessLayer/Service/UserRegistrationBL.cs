using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer.Service;
using ModelLayer.DTO;

namespace BusinessLayer.Service
{
    public class UserRegistrationBL
    {

        UserRegistrationRL _userRegistrationRL;
        public UserRegistrationBL(UserRegistrationRL userRegistrationRL) 
        {
            _userRegistrationRL = userRegistrationRL;
        }

        public string registrationBL(string name)
        {
            return " Data from business layer " + _userRegistrationRL.registrationRL(name);
            
        }

        public bool RegisterUser(RegisterDTO user)
        {
            return _userRegistrationRL.RegisterUser(user);
        }

        public RegisterDTO GetUserByEmail(string email)
        {
            return _userRegistrationRL.GetUserByEmail(email);
        }
    }
}
