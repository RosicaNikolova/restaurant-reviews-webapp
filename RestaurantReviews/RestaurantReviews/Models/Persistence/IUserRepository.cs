using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviews.Models
{
    public interface IUserRepository
    {
        public User FindUser(string email, string password);

        public User FindUserByEmail(string email);

        public List<User> FindAll();
        
        public bool SaveUser(User user);

        public bool DeleteUser(User user);
        
    }
}
