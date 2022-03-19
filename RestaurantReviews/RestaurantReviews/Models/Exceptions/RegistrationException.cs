using System;
using System.Runtime.Serialization;

namespace RestaurantReviews.Models
{
    [Serializable]
    public class RegistrationException : Exception
    {
        public RegistrationException()
        {

        }

        public RegistrationException(string message) : base(message)
        {

        }

        
    }
}