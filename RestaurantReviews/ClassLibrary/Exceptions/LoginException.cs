using System;
using System.Runtime.Serialization;

namespace ClassLibrary.Exceptions
{
    [Serializable]
    public class LoginException : Exception
    {
        public LoginException()
        {
        }

        public LoginException(string message) : base(message)
        {

        }

    }
}