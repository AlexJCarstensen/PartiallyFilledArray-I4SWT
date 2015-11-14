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
    }
}