using ModelLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface IUserRegistrationBL
    {
        string registrationBL(string name);
        bool RegisterUser(RegisterDTO user);
        RegisterDTO GetUserByEmail(string email);
    }
}
