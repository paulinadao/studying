using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Studying;

namespace UnitTestProject1
{
    [TestClass]
    public class BinaryTreeTests
    {
        [TestMethod]
        public void NullHead()
        {
            Node NullNode = new Node();
            NullNode.data = 0;
            NullNode.left = null;
            NullNode.right = null;

            Assert.AreEqual(0, NullNode.data);
            Assert.IsNull(NullNode.left);
            Assert.IsNull(NullNode.right);
    
        }

        [TestMethod]
        public void InsertOne()
        {
            Node HeadNode = new Node();
            HeadNode.data = 3;
            HeadNode.left = null;
            HeadNode.right = null;

            var tree = new BinaryTree();

            Assert.AreEqual(3, HeadNode.data);
            Assert.IsNull(HeadNode.left);
            Assert.IsNull(HeadNode.right);

            tree.Insert(HeadNode, 5);

            Assert.IsNull(HeadNode.left);
            Assert.IsNotNull(HeadNode.right);
            Assert.AreEqual(5, HeadNode.right.data);
            Assert.IsNull(HeadNode.right.left);
            Assert.IsNull(HeadNode.right.right);

        }

        [TestMethod]
        public void Size()
        {


        }
    }
}
