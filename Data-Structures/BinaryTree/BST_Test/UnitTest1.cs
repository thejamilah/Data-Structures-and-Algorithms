using BinaryTree;
using System;
using Xunit;

namespace BST_Test
{
    public class UnitTest1
    {
        [Fact]
        public void BSTreeTest()
        {
            //arrange test constructor

            //act "line of code to test"
            BinarySearchTree tree1 = new BinarySearchTree();
            //assert is null 
            Assert.Null(tree1.root);
        }
        
        [Fact]
        public void BinaryTreePreorderTest()
        {
            //arrange
            Node node = new Node(10);
            //act

            //assert
        }
    }
}
