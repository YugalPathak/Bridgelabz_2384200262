using ModelLayer.DTO;
using RepositoryLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class UserService
    {
        private readonly ResetPasswordRL _resetPassword;
        private readonly RabbitMQProducer _rabbitMQProducer;

        public UserService(ResetPasswordRL resetPassword, RabbitMQProducer rabbitMQProducer)
        {
            _resetPassword = resetPassword;
            _rabbitMQProducer = rabbitMQProducer;
        }

        public string RequestPasswordReset(string email)
        {
            string token = _resetPassword.GenerateResetToken(email);
            if (token == null) return null;

            var message = new MessageModel { Email = email, Token = token };
            _rabbitMQProducer.PublishMessage(message);

            return token;
        }

        public bool UpdatePassword(string token, string newPassword)
        {
            return _resetPassword.ResetPassword(token, newPassword);
        }
    }
}
