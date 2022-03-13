using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviews.Models
{
    public class LoginManager
    {
        UserRepository userRepository = new UserRepository();

        public User Login(string email, string password)
        {
            User user = userRepository.FindUser(email, password);

            if(user == null)
            {
                throw new LoginException("User does not exist");
            }
            else
            {
                return user;
            }
            
        }

    }
}
