using System;
using System.Runtime.Serialization;

namespace LabCours3OminiPop
{
    [Serializable]
    internal class anneNoMatch : Exception
    {
        public anneNoMatch()
        {
        }

        public anneNoMatch(string message) : base(message)
        {
        }

        public anneNoMatch(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected anneNoMatch(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}