
using ClassLibrary.Business;
using ClassLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Text;


namespace UnitTests.Persistence
{
    class FakeUserRepository : IUserRepository
    {
        public List<User> users;

        public FakeUserRepository(List<User> users)
        {
            this.users = users;
        }

        public User FindUser(string email, string password)
        {
            foreach (User u in users)
            {
                if (u.Email == email && u.Password == password)
                {
                    return u;
                }
            }
            return null;
        }

        public void DeleteUser(User user)
        {
           if (users.Contains(user))
            {
                users.Remove(user);
            }
        }

        public User FindUserByEmail(string email)
        {
            foreach (User user in users)
            {
                if(user.Email == email)
                {
                    return user;
                }
            }
            return null;
        }

        public List<User> FindAll()
        {
            if(users.Count != 0)
            {
                return users;
            }
            else
            {
                return null;
            }
        }

        public void SaveUser(User user)
        {
           if(user.LastName == "")
            {
            
            }
            else
            {
                user.Id = 1;
                users.Add(user);
            
            }
        }

        public string GetNameOfUser(int userId)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsersEligibleForDiscount()
        {
            throw new NotImplementedException();
        }

        public User FindUserById(int userId)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }      
}
