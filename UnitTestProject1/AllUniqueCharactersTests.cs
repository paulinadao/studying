using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Studying;

namespace UnitTestProject1
{
    using Studying;

    [TestClass]
    public class AllUniqueCharactersTests
    {
        [TestMethod]
        public void NoDuplicates()
        {
            var noDuplicateAnswer = AllUniqueCharacters.UniqueCharacters("Hi cat!Meow");

            Assert.IsTrue(noDuplicateAnswer);
        }

        [TestMethod]
        public void HasDuplicates()
        {
            var yesDuplicateAnswer = AllUniqueCharacters.UniqueCharacters("I love kittens!");

            Assert.IsFalse(yesDuplicateAnswer);
        }

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void NullOrEmpty()
        {
            var emptyString = "";
            var nullEmptyAnswer = AllUniqueCharacters.UniqueCharacters(emptyString);

        }
    }
}
