using System;
using System.Runtime.Serialization;

namespace RestaurantReviews.Models
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