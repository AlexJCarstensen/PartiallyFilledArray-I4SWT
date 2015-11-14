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
    }
}