using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Business;

namespace ClassLibrary.Persistence
{
    public interface IUserRepository
    {
        public User FindUser(string email, string password);

        public User FindUserByEmail(string email);

        public List<User> FindAll();
        
        public bool SaveUser(User user);

        public bool DeleteUser(User user);
        string GetNameOfUser(int userId);
        List<User> GetUsersEligibleForDiscount();
        User FindUserById(int userId);
        void UpdateUser(User user);
    }
}
