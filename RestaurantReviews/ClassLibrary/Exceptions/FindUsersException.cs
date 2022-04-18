using System;
using System.Runtime.Serialization;

namespace ClassLibrary.Exceptions
{
    [Serializable]
    public class FindUsersException : Exception
        {
        public FindUsersException()
        {
        }

        public FindUsersException(string message) : base(message)
        {
        }

       
    }
}