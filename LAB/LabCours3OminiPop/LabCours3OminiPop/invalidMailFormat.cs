using System;
using System.Runtime.Serialization;

namespace LabCours3OminiPop
{
    [Serializable]
    internal class invalidMailFormat : Exception
    {
        public invalidMailFormat()
        {
        }

        public invalidMailFormat(string message) : base(message)
        {
        }

        public invalidMailFormat(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected invalidMailFormat(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}