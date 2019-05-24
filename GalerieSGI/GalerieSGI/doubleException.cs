using System;
using System.Runtime.Serialization;

namespace GalerieSGI
{
    [Serializable]
    internal class doubleException : Exception
    {
        public doubleException()
        {
        }

        public doubleException(string message) : base(message)
        {
        }

        public doubleException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected doubleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}