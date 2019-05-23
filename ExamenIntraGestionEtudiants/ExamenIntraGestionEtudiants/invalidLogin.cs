using System;
using System.Runtime.Serialization;

namespace ExamenIntraGestionEtudiants
{
    [Serializable]
    internal class invalidLogin : Exception
    {
        public invalidLogin()
        {
        }

        public invalidLogin(string message) : base(message)
        {
        }

        public invalidLogin(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected invalidLogin(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}