using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RepositoryLayer.Service.ResetPasswordRL;

namespace BusinessLayer.Service
{
    public class ResetPasswordBL
    {
        public class UserService
        {
            private readonly UserRepository _userRepository;

            public UserService(UserRepository userRepository)
            {
                _userRepository = userRepository;
            }

            public string RequestPasswordReset(string email)
            {
                return _userRepository.GenerateResetToken(email);
            }

            public bool UpdatePassword(string token, string newPassword)
            {
                return _userRepository.ResetPassword(token, newPassword);
            }
        }

    }
}
