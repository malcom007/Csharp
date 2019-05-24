using System;
using System.Runtime.Serialization;

namespace LabCours3OminiPop
{
    [Serializable]
    internal class anneeInvalides : Exception
    {
        public anneeInvalides()
        {
        }

        public anneeInvalides(string message) : base(message)
        {
        }

        public anneeInvalides(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected anneeInvalides(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}