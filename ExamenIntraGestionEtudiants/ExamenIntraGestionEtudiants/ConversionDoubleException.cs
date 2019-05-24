using System;
using System.Runtime.Serialization;

namespace ExamenIntraGestionEtudiants
{
    [Serializable]
    internal class ConversionDoubleException : Exception
    {
        public ConversionDoubleException()
        {
        }

        public ConversionDoubleException(string message) : base(message)
        {
        }

        public ConversionDoubleException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ConversionDoubleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}