using System;
using System.Runtime.Serialization;

namespace ExamenIntraGestionEtudiants
{
    [Serializable]
    internal class choixInvidException : Exception
    {
        public choixInvidException()
        {
        }

        public choixInvidException(string message) : base(message)
        {
        }

        public choixInvidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected choixInvidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}