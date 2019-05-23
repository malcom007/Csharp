using System;
using System.Runtime.Serialization;

namespace ExamenIntraGestionEtudiants
{
    [Serializable]
    internal class nombreEtudiantAtteint : Exception
    {
        public nombreEtudiantAtteint()
        {
        }

        public nombreEtudiantAtteint(string message) : base(message)
        {
        }

        public nombreEtudiantAtteint(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected nombreEtudiantAtteint(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}