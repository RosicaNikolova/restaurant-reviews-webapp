using System;
using System.Runtime.Serialization;

namespace ClassLibrary.Exceptions
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