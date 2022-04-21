using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Business
{
    public interface IUserManager
    {
        public User FindUser(string email, string password);
        public List<User> FindAllUsers();
        public void DeleteUser(User user);
        public string GetNameOfUser(int userId);      
        public List<User> FindAllUsersEligibleForDiscount();
        public User FindUserById(int userId);
        public void UpdateUser(string email, string password, string firstName, string lastName, int userId);  
    }
}
