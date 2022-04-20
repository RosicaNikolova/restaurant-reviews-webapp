﻿
using ClassLibrary.Exceptions;
using ClassLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary.Business
{
    public class UserManager
    {
        private IUserRepository userRepository;

        public UserManager(IUserRepository repository)
        {
            this.userRepository = repository;
        }

        public User FindUser(string email, string password)
        {
            User user = userRepository.FindUser(email, password);

            if (user == null)
            {
                throw new LoginException();
            }
            else
            {
                return user;
            }


            //if (userRepository.FindUser(email, password) != null)
            //{
            //    return userRepository.FindUser(email, password);
            //}
            //else
            //{
            //    return null;
            //}
        }

       

        public List<User> FindAllUsers()
        {
            List<User> users = userRepository.FindAll();
            if (users != null)
            {
                return users;
            }
            else
            {
                throw new FindUsersException();
            }     
        }

        //public void CreateUser(string email, string password, string firstName, string lastName)
        //{
        //    if (userRepository.FindUser(email, password) != null)
        //    {
        //        throw new UserExistsException("User already exists");
        //    }
        //    else
        //    {
        //        User user = new User();
        //        user.Email = email;
        //        user.Password = password;
        //        user.FirstName = firstName;
        //        user.LastName = lastName;
        //        userRepository.SaveUser(user);
        //    }
        //}

        public void DeleteUser(User user)
        {
            if (!userRepository.DeleteUser(user))
            {
                throw new DelteUserException();
            }
        }

        public string GetNameOfUser(int userId)
        {
            string userName = userRepository.GetNameOfUser(userId);
            return userName;
        }

        public List<User> FindAllUsersEligibleForDiscount()
        {
            List<User> users = new List<User>();
            users = userRepository.GetUsersEligibleForDiscount();
            return users;
        }

        public User FindUserById(int userId)
        {
            User user = new User();
            user = userRepository.FindUserById(userId);
            return user;
        }

        public void UpdateUser(string email, string password, string firstName, string lastName, int userId)
        {
            User user = new User();
            user.Email = email;
            user.Password = password;
            user.FirstName = firstName;
            user.LastName = lastName;
            user.Id = userId;
            userRepository.UpdateUser(user);
        }

    }
}
