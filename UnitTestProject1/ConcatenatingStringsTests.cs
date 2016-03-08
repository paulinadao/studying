using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Studying.UnitTests
{
    using System.IO;

    using Studying;

    [TestClass]
    public class ConcatenationTest
    {
        [TestMethod]
        public void TwoWordsMatch()
        {
            string[] list = new string[] { "cat", "meow", "apple", "happy", "kitten" };
            string target = "kittencat";
            var answer = ConcatenatingStrings.ConcatenationExists(list, target);

            Assert.IsTrue(answer);

        }

        [TestMethod]
        public void OneWordMatch()
        {
            string[] list = new string[] { "cat", "apple", "burger", "kitten", "meow", "toilet" };
            string target = "catastrophic";
            var answer = ConcatenatingStrings.ConcatenationExists(list, target);

            Assert.IsFalse(answer);
        }

        [TestMethod]
        public void NoMatches()
        {
            string[] list = new string[] { "cat", "dog", "lion", "apple", "volleyball" };
            string target = "onions";
            var answer = ConcatenatingStrings.ConcatenationExists(list, target);

            Assert.IsFalse(answer);
        }

    }
}
