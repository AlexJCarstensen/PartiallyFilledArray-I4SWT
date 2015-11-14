using System;
using System.Runtime.Serialization;

namespace Exceptions_PartiallyFilledArray.Exceptions
{
    [Serializable]
    public class PFAArrayFullException : Exception
    {
        public PFAArrayFullException()
        {
        }

        public PFAArrayFullException(string message) : base(message)
        {
        }

        public PFAArrayFullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PFAArrayFullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}