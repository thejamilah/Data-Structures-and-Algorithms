using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class BinaryTree
    {
        public class Node
        {
            public Node root;
            public int count;

            public void BinaryTree()
            {
                root = null;
                count = 0;
            }
            public bool isEmpty()
            {
                return root == null;
            }

        }
    }
}
