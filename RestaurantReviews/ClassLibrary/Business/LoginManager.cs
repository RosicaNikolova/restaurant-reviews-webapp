﻿using ClassLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary.Business
{
    public class LoginManager : ILoginManager
    {
        private IUserRepository userRepository;

        public LoginManager(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public User Login(string email, string password)
        {
            User user = userRepository.FindUser(email, password);
            return user;      
        }
    }
}
