using System;
using System.Runtime.Serialization;

namespace ClassLibrary.Exceptions
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