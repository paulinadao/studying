using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Studying;

namespace UnitTestProject1
{
    [TestClass]
    public class IsWordInStringTests
    {
        [TestMethod]
        public void WordIsInString()
        {
            var string1 = "concatenate";
            var string2 = "cat";

            var result = IsWordInString.IsString1InString2(string1, string2);
            
        }
    }
}
