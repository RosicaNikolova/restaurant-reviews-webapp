
using ClassLibrary.Business;
using ClassLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Text;


namespace UnitTests.Persistence
{
    class FakeUserRepository : IUserRepository
    {
        private List<User> users;

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

        public bool DeleteUser(User user)
        {
            foreach (User u in users)
            {
                if (user.Id == u.Id)
                {
                    users.Remove(u);
                    return true;
                }
            }
            return false;
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

        public bool SaveUser(User user)
        {
           if(user.LastName == "")
            {
                return false;
            }
            else
            {
                user.Id = 1;
                users.Add(user);
                return true;
            }
        }
    }

       
}
