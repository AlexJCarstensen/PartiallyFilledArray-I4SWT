using System;
using System.CodeDom;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using Exceptions_PartiallyFilledArray.Exceptions;

namespace Exceptions_PartiallyFilledArray
{
    public class PartiallyFilledArray : IPartiallyFilledArray
    {
        
        private int[] _array = null;
        public PartiallyFilledArray(int arraySize)
        {
            Used = 0;
            Size = (uint)arraySize;
            _array = new int[Size+1];
            
            for (uint i = 0; i <= 5; i++)
            {
                Set(i, (int)i + 1);
            }
            Set(8,8);
            Set(9,10);
            Set(12,4);
            Set(13,15);
            Set(14,2);

            
        }

        public uint Size { get; }
        public uint Used { get; set;  }
        public void Set(uint pos, int data)
        {
            if (pos > Size)
                throw new PFAIndexOutOfBoundsException();
            _array.SetValue(data,pos);
            Used++;
        }

        public int Get(uint pos)
        {
            if ((int)_array.GetValue(pos) == 0)
                throw new PFANoDataAtIndexException();
            return (int) _array.GetValue(pos);
        }

        public uint Put(int data)
        {
            if(Used == Size)
                throw new PFAArrayFullException();
            uint index = 0;
            for (int i = 0; i < _array.Length - 1 ; i++)
            {
                if (_array[i] != 0) continue;
                    Set((uint) i, data);
                index = (uint) i;
                break;
            }
            
            return index;
        }

        public uint Find(int data)
        {
            var index = Array.IndexOf(_array, data);
            if (index < 0)
                return  Size;
            return (uint)index;
        }

        public void RemoveAt(uint pos)
        {
            if (pos > Size)
                throw new PFAIndexOutOfBoundsException();
            if ((int) _array.GetValue(pos) == 0)
                throw new PFANoDataAtIndexException();
            Array.Clear(_array, (int) pos,1);
            Used--;
        }
    }
}