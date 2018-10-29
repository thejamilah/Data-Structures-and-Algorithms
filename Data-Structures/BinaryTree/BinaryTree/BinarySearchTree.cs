using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }

        public void add(int value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (value< current.Value)
                    {
                        current = current.LeftChild;
                        if (current == null)
                        {
                            parent.LeftChild = newNode;
                            break;
                        }

                    }
                    else
                    {
                        current = current.RightChild;
                        if (current == null)
                        {
                            parent.RightChild = newNode;
                            break;
                        }
                    }
                }
            }

        }
    }
}
