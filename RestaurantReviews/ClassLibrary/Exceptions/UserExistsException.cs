using System;
using System.Runtime.Serialization;

namespace ClassLibrary.Exceptions
{
    [Serializable]
    internal class UserExistsException : Exception
    {
        public UserExistsException()
        {

        }

        public UserExistsException(string message) : base(message)
        {

        }

    }
}