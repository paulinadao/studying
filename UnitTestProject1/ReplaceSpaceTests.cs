using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    using Studying;

    [TestClass]
    public class ReplaceSpaceUnitTest
    {
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void NullString()
        {
            var answer = ReplaceSpace.ReplacingSpaces(null);

        }

        [TestMethod]
        public void OneSpace()
        {
            var answer = ReplaceSpace.ReplacingSpaces(" ");
            var expected = "%20";

            Assert.AreEqual(expected, answer);
        }

        [TestMethod]
        public void PreAndPostSpace()
        {
            var answer = ReplaceSpace.ReplacingSpaces(" HelloCat ");
            var expected = "%20HelloCat%20";

            Assert.AreEqual(expected, answer);
        }

        [TestMethod]
        public void AFullSentence()
        {
            var answer = ReplaceSpace.ReplacingSpaces("Test test");

            Assert.AreEqual("Test%20test", answer);
        }

        [TestMethod]
        public void OneWord()
        {
            var answer = ReplaceSpace.ReplacingSpaces("cat");

            Assert.AreEqual("cat", answer);
        }
    }
}
