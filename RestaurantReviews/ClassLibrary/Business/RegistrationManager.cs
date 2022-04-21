using ClassLibrary.Business;
using ClassLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary.Business
{
    public class RegistrationManager : IRegistrationManager
    {

        private IUserRepository userRepository;

        public RegistrationManager(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

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
                return user;
            }
            else
            {
                return null;
            }
        }
    }
}
