using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exceptions_PartiallyFilledArray.Exceptions;
using NSubstitute;
using NUnit.Framework;

namespace Exceptions_PartiallyFilledArray.Test.Unit
{
    [TestFixture]
    public class Exceptions_PartiallyFilledArrayUnitTest
    {
        private IPartiallyFilledArray _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new PartiallyFilledArray(15);
        }

        [Test]
        public void SetAndGet_Pos6Data5_Return5()
        {
            _uut.Set(6, 5);
            Assert.That(_uut.Get(6), Is.EqualTo(5));
        }

        [Test]
        public void Set_Pos16Data5_ThrowsException()
        {
            Assert.Throws<PFAIndexOutOfBoundsException>(() => _uut.Set(16, 5));
        }

        [Test]
        public void Get_NoDataAtPos5_ThrowsException()
        {
            _uut.Set(5,0);
            Assert.Throws<PFANoDataAtIndexException>(() => _uut.Get(5));
        }

        [Test]
        public void Put_Data5_returnIndex6()
        {
            Assert.That(_uut.Put(5), Is.EqualTo(6));
        }

        [Test]
        public void Put_ArrayFull_ThrowException()
        {
            while(_uut.Used != _uut.Size)
                _uut.Put(15);
            Assert.Throws<PFAArrayFullException>(() => _uut.Put(15));
        }

        [Test]
        public void Find_Data15_ReturnIndex13()
        {
            Assert.That(_uut.Find(15), Is.EqualTo(13));
        }

        [Test]
        public void Find_NotExistingData100_returnSize()
        {
            Assert.That(_uut.Find(100), Is.EqualTo(_uut.Size));
        }

        [Test]
        public void RemoveAt_Index1_ThrowNoDataException()
        {
            _uut.RemoveAt(1);
            Assert.Throws<PFANoDataAtIndexException>(() => _uut.Get(1));
        }
        [Test]
        public void RemoveAt_Index16_PFAIndexOutOfBoundsException()
        {
            Assert.Throws<PFAIndexOutOfBoundsException>(() => _uut.RemoveAt(16));
        }
        [Test]
        public void RemoveAt_Index7_PFANoDataAtIndexException()
        {
            Assert.Throws<PFANoDataAtIndexException>(() => _uut.RemoveAt(7));
        }

    }
}
