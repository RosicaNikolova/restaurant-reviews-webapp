using System;
using System.Runtime.Serialization;

namespace ClassLibrary.Exceptions
{
    [Serializable]
    public class RegistrationException : Exception
    {
        public RegistrationException()
        {

        }

        public RegistrationException(string message) : base(message)
        {

        }

        
    }
}