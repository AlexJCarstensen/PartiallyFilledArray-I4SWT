using System;
using System.Runtime.Serialization;

namespace Exceptions_PartiallyFilledArray.Exceptions
{
    [Serializable]
    public class PFAIndexOutOfBoundsException : Exception
    {
        public int _Pos;
        public int _Count;
        public PFAIndexOutOfBoundsException()
        {
        }

        public PFAIndexOutOfBoundsException(string message) : base(message)
        {
        }

        public PFAIndexOutOfBoundsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PFAIndexOutOfBoundsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}