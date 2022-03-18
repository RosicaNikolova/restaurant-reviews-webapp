using System;
using System.Runtime.Serialization;

namespace RestaurantReviews.Models
{
    [Serializable]
    public class FindUsersException : Exception
        {
        public FindUsersException()
        {
        }

        public FindUsersException(string message) : base(message)
        {
        }

       
    }
}