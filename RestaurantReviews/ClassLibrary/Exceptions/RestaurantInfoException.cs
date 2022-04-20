using System;
using System.Runtime.Serialization;

namespace ClassLibrary.Business
{
    [Serializable]
    public class RestaurantInfoException : Exception
    {
        public RestaurantInfoException()
        {
        }

        public RestaurantInfoException(string message) : base(message)
        {
        }

        public RestaurantInfoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RestaurantInfoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}