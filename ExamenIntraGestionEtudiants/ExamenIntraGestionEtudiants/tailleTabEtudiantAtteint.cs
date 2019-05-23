using System;
using System.Runtime.Serialization;

namespace ExamenIntraGestionEtudiants
{
    [Serializable]
    internal class tailleTabEtudiantAtteint : Exception
    {
        public tailleTabEtudiantAtteint()
        {
        }

        public tailleTabEtudiantAtteint(string message) : base(message)
        {
        }

        public tailleTabEtudiantAtteint(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected tailleTabEtudiantAtteint(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}