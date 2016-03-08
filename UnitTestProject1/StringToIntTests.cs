using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    using System.IO;
    using Studying;

    [TestClass]
    public class StringToIntTests
    {

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void NoDigits()
        {
            var answer = ConvertingStringToInt.StringToInteger("abcd");
        }

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void NullString()
        {
            var answer = ConvertingStringToInt.StringToInteger(null);
        }

        [ExpectedException(typeof(OverflowException))]
        [TestMethod]
        public void MaxIntPlus1()
        {
            string input = "2147483648";

            var returnedValue = ConvertingStringToInt.StringToInteger(input);

            Assert.AreEqual(int.MaxValue, returnedValue);

        }

        [ExpectedException(typeof(OverflowException))]
        [TestMethod]
        public void MaxIntPlus2()
        {
            string input = "2147483649";

            var returnedValue = ConvertingStringToInt.StringToInteger(input);

        }

        [TestMethod]
        public void MaxInt()
        {
            string input = "2147483647";

            var returnedValue = ConvertingStringToInt.StringToInteger(input);


            Assert.AreEqual(int.MaxValue, returnedValue);
        }

        [TestMethod]
        public void MinInt()
        {
            string input = "-2147483648";

            var returnedValue = ConvertingStringToInt.StringToInteger(input);

            Assert.AreEqual(int.MinValue, returnedValue);
        }

        [ExpectedException(typeof(OverflowException))]
        [TestMethod]
        public void MinIntMinus1()
        {
            string input = "-2147483649";

            var returnedValue = ConvertingStringToInt.StringToInteger(input);

        }


        [TestMethod]
        public void NegativeInt()
        {
            string input = "-10";

            var returnedValue = ConvertingStringToInt.StringToInteger(input);

            Assert.AreEqual(-10, returnedValue);
        }

        [TestMethod]
        public void DifferentCharacters()
        {
            var answer = ConvertingStringToInt.StringToInt("13");

            Assert.AreEqual(13, answer);
        }

        [TestMethod]
        public void Thousands()
        {
            var answer = ConvertingStringToInt.StringToInt("1989");

            Assert.AreEqual(1989, answer);
        }

        [TestMethod]
        public void SameCharacters()
        {
            var answer = ConvertingStringToInt.StringToInt("22");

            Assert.AreEqual(22, answer);

        }

        [TestMethod]
        public void Negatives()
        {
            var answer = ConvertingStringToInt.StringToInt("-100");

            Assert.AreEqual(-100, answer);
        }


       
    }
}
