using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Studying;

namespace UnitTestProject1
{
    [TestClass]
    public class RemoveDuplicateCharactersTests
    {
        [TestMethod]
        public void AllDuplicateCharacters()
        {
            var answer = RemoveDuplicateCharacters.RemovingDuplicateCharacters("aaaaaaaaaaaaaaaaaaaaa");
            var expected = "a";

            Assert.AreEqual(expected, answer);

        }

        [TestMethod]
        public void SentencesWithSpaces()
        {
            var answer = RemoveDuplicateCharacters.RemovingDuplicateCharacters("Hi cat meow");
            var expected = "Hi catmeow";

            Assert.AreEqual(expected, answer);

        }

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void NullSentences()
        {
            var answer = RemoveDuplicateCharacters.RemovingDuplicateCharacters("");
         

        }

        [TestMethod]
        public void WhiteSpace()
        {
            var answer = RemoveDuplicateCharacters.RemovingDuplicateCharacters(" ");
            var expected = " ";

            Assert.AreEqual(expected, answer);

        }
    }
}
