using System;
using System.Runtime.Serialization;

namespace Exceptions_PartiallyFilledArray.Exceptions
{
    [Serializable]
    public class PFANoDataAtIndexException : Exception
    {
        public int _pos;
        public PFANoDataAtIndexException()
        {
        }

        public PFANoDataAtIndexException(string message) : base(message)
        {
        }

        public PFANoDataAtIndexException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PFANoDataAtIndexException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}