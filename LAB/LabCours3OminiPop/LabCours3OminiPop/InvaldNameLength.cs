using System;
using System.Runtime.Serialization;

namespace LabCours3OminiPop
{
    [Serializable]
    internal class InvaldNameLength : Exception
    {
        public InvaldNameLength()
        {
        }

        public InvaldNameLength(string message) : base(message)
        {
        }

        public InvaldNameLength(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvaldNameLength(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}