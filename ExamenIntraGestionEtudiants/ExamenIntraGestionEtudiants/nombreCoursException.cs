using System;
using System.Runtime.Serialization;

namespace ExamenIntraGestionEtudiants
{
    [Serializable]
    internal class nombreCoursException : Exception
    {
        public nombreCoursException()
        {
        }

        public nombreCoursException(string message) : base(message)
        {
        }

        public nombreCoursException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected nombreCoursException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}