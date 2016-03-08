using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Studying;

namespace Studying.UnitTests
{
    [TestClass]
    public class GrabScrabTests
    {
        [TestMethod]
        public void AllSameLetters()
        {
            var one = "red";
            var two = "deer";

            var answer = GrabScrab.StealCharactersInOne(one, two);

            Assert.IsTrue(answer);
        }

        [TestMethod]
        public void OneLetter()
        {
            var one = "a";
            var two = "aaaaaaa";

            var answer = GrabScrab.StealCharactersInOne(one, two);

            Assert.IsTrue(answer);
        }

        [TestMethod]
        public void NoMatches()
        {
            var one = "dog";
            var two = "qwerty";

            var answer = GrabScrab.StealCharactersInOne(one, two);

            Assert.IsFalse(answer);
        }

        [TestMethod]
        public void StringOneinTwo()
        {
            var one = "cat";
            var two = "concatenation";

            var answer = GrabScrab.StealCharactersInOne(one, two);

            Assert.IsTrue(answer);
        }

        [TestMethod]
        public void CapsInStrings()
        {
            var one = "CAT";
            var two = "concatenation";

            var answer = GrabScrab.StealCharactersInOne(one, two);

            Assert.IsTrue(answer);
        }
    }
}
