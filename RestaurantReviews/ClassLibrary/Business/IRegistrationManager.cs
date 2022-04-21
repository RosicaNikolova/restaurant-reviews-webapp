using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Business
{
    public interface IRegistrationManager
    {
        public User Register(string email, string password, string firstName, string lastName);
    }
}
