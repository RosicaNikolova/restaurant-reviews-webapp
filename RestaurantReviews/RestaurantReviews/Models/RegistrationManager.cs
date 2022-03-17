﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviews.Models
{
    public class RegistrationManager
    {
        UserRepository userRepository = new UserRepository();

        public User Register(string email, string password, string firstName, string lastName)
        {
            User user = userRepository.FindUserByEmail(email);
            if(user == null)
            {
                user = new User();
                user.Email = email;
                user.Password = password;
                user.FirstName = firstName;
                user.LastName = lastName;
                user.Roles = Role.USER;
                userRepository.SaveUser(user);
            }
            return user;
            
        }

        public User UserExists(string email)
        {
            User user = userRepository.FindUserByEmail(email);
            return user;

        }
    }
}
