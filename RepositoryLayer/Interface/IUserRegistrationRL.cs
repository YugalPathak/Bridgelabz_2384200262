using ModelLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interface
{
    public interface IUserRegistrationRL
    {
        string registrationRL(string name);
        RegisterDTO GetUserByEmail(string Email);
        bool RegisterUser(RegisterDTO user);
    }
}
