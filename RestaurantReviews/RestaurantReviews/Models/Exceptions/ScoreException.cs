using System;
using System.Runtime.Serialization;

namespace RestaurantReviews.Models
{
    [Serializable]
    public class ScoreException : Exception
    {
        public ScoreException()
        {
        }

        public ScoreException(string message) : base(message)
        {
        }
    }

       
}