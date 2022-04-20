using System;
using System.Runtime.Serialization;

namespace ClassLibrary.Exceptions
{
    [Serializable]
    public class RestaurantException : Exception
    {
        public RestaurantException()
        {
        }

        public RestaurantException(string message) : base(message)
        {
        }

        public RestaurantException(string message, Exception innerException) : base(message, innerException)
        {

        }

        protected RestaurantException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}