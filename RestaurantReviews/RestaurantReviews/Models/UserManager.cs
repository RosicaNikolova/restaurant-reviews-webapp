using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviews.Models
{
    public class UserManager
    {
        UserRepository userRepository = new UserRepository();

        public User findUser(string email, string password)
        {
            if (userRepository.FindUser(email, password) != null)
            {
                return userRepository.FindUser(email, password);
            }
            else
            {
                return null;
            }
        }
    }
}
