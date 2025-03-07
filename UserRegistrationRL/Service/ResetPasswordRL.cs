using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Service
{
    public class ResetPasswordRL
    {
        public class UserRepository
        {
            private readonly DbContext _context;

            public UserRepository(DbContext context)
            {
                _context = context;
            }

            public string GenerateResetToken(string email)
            {
                var user = _context.Users.FirstOrDefault(u => u.Email == email);
                if (user == null) return null;

                user.ResetToken = Guid.NewGuid().ToString();
                user.TokenExpiry = DateTime.UtcNow.AddHours(1); // Token valid for 1 hour

                _context.SaveChanges();
                return user.ResetToken;
            }

            public bool ResetPassword(string token, string newPassword)
            {
                var user = _context.Users.FirstOrDefault(u => u.ResetToken == token && u.TokenExpiry > DateTime.UtcNow);
                if (user == null) return false;

                user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);
                user.ResetToken = null;
                user.TokenExpiry = null;

                _context.SaveChanges();
                return true;
            }
        }

    }
}
