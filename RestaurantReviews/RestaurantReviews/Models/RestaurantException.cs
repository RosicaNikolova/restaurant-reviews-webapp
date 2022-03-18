using System;
using System.Runtime.Serialization;

namespace RestaurantReviews.Models
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

        
    }
}