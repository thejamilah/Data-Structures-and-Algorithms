using System;
using System.Collections.Generic;

namespace BinaryTree
{
    public class BinaryTree
    {
        public static void inOrder(Node root)
        {

        }

        public static List<Node> preOrder(Node root)
        {
            Console.WriteLine(root.Value);
            List<Node> nodeArray = new List<Node>();
            nodeArray.Add(root);
            if (root.LeftChild != null)
            {
                nodeArray.AddRange(preOrder(root.LeftChild));   
            }
            if (root.RightChild != null)
            {
                nodeArray.AddRange(preOrder(root.RightChild));
            }
            return nodeArray;
        }

        public static void postOrder(Node root)
        {

        }
    }
}
