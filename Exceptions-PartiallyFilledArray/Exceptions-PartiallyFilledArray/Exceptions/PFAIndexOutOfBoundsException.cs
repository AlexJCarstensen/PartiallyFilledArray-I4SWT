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
    }
}