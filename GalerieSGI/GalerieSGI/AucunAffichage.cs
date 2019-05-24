using System;
using System.Runtime.Serialization;

namespace GalerieSGI
{
    [Serializable]
    internal class AucunAffichage : Exception
    {
        public AucunAffichage()
        {
        }

        public AucunAffichage(string message) : base(message)
        {
        }

        public AucunAffichage(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AucunAffichage(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}