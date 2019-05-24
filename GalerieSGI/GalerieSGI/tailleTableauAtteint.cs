using System;
using System.Runtime.Serialization;

namespace GalerieSGI
{
    [Serializable]
    internal class tailleTableauAtteint : Exception
    {
        public tailleTableauAtteint()
        {
        }

        public tailleTableauAtteint(string message) : base(message)
        {
        }

        public tailleTableauAtteint(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected tailleTableauAtteint(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}