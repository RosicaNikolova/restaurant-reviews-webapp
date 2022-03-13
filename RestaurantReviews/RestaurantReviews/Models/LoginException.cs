using System;
using System.Runtime.Serialization;

namespace RestaurantReviews.Models
{
    [Serializable]
    internal class LoginException : Exception
    {
        public LoginException()
        {
        }

        public LoginException(string message) : base(message)
        {

        }

    }
}