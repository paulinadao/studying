using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Studying;

namespace Studying.UnitTests
{
    [TestClass]
    public class DivisibleByThreeMultipleOfThreeTests
    {
       

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void NullArgument()
        {
            DivisibleByThreeMultipleOfThree.Threes(0);
        }

        //[TestMethod]
        //public void MaxInt()
        //{
        //    DivisibleByThreeMultipleOfThree.Threes(int.MaxValue);
        //}

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void NegativeInt()
        {
            DivisibleByThreeMultipleOfThree.Threes(-10);
        }

        //[TestMethod]
        //public void Integer()
        //{
        //    DivisibleByThreeMultipleOfThree.Threes(8);
        //}
    }
}
