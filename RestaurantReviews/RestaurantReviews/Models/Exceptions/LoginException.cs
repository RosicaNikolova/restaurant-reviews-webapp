using System;
using System.Runtime.Serialization;

namespace RestaurantReviews.Models
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