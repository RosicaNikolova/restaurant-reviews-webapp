using System;
using System.Runtime.Serialization;

namespace RestaurantReviews.Models
{
    [Serializable]
    public class ReviewException : Exception
    {
        public ReviewException()
        {
        }

        public ReviewException(string message) : base(message)
        {
        }

        public ReviewException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ReviewException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}