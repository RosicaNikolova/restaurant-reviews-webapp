using System;
using System.Runtime.Serialization;

namespace ClassLibrary.Exceptions
{
    [Serializable]
    public class SaveUserException : Exception
    {
        public SaveUserException()
        {
        }

        public SaveUserException(string message) : base(message)
        {
        }

        
    }
}