using System;
using System.Runtime.Serialization;

namespace ClassLibrary.Exceptions
{
    [Serializable]
    public class DelteUserException : Exception
    {
        public DelteUserException()
        {
        }

        public DelteUserException(string message) : base(message)
        {
        }

        public DelteUserException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DelteUserException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}