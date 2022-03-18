using System;
using System.Runtime.Serialization;

namespace RestaurantReviews.Models
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