using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using RepositoryLayer.Service;
using ModelLayer.DTO;
using RepositoryLayer.Interface;
using BusinessLayer.Interface;

namespace BusinessLayer.Service
{
    public class UserRegistrationBL : IUserRegistrationBL
    {
        private readonly IUserRegistrationRL _userRegistrationRL;
        private readonly ILogger<UserRegistrationBL> _logger;

        public UserRegistrationBL(IUserRegistrationRL userRegistrationRL, ILogger<UserRegistrationBL> logger)
        {
            _userRegistrationRL = userRegistrationRL;
            _logger = logger;
        }

        public string registrationBL(string name)
        {
            try
            {
                return "Data from business layer " + _userRegistrationRL.registrationRL(name);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Business Layer");
                return "Error occurred";
            }
        }

        public bool RegisterUser(RegisterDTO user)
        {
            try
            {
                return _userRegistrationRL.RegisterUser(user);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Business Layer");
                return false;
            }
        }

        public RegisterDTO GetUserByEmail(string email)
        {
            try
            {
                return _userRegistrationRL.GetUserByEmail(email);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Business Layer");
                return null;
            }
        }
    }
}