using System;
using System.Runtime.Serialization;

namespace ExamenIntraGestionEtudiants
{
    [Serializable]
    internal class nombreTentativeAtteint : Exception
    {
        public nombreTentativeAtteint()
        {
        }

        public nombreTentativeAtteint(string message) : base(message)
        {
        }

        public nombreTentativeAtteint(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected nombreTentativeAtteint(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}