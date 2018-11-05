using System;
using System.Collections.Generic;

namespace BinaryTree
{
    public class BinaryTree
    {
        public static List<Node> InOrder(Node root)
        {

        }

        public static List<Node> PreOrder(Node root)
        {
            Console.WriteLine(root.Value);
            List<Node> nodeArray = new List<Node>();
            nodeArray.Add(root);
            if (root.LeftChild != null)
            {
                nodeArray.AddRange(PreOrder(root.LeftChild));   
            }
            if (root.RightChild != null)
            {
                nodeArray.AddRange(PreOrder(root.RightChild));
            }
            return nodeArray;
        }

        public static List<Node> PostOrder(Node root)
        {
            Console.WriteLine(root.Value);
            List<Node> nodeArray = new List<Node>();
            nodeArray.Add(root);
            if (root.LeftChild != null)
            {
                nodeArray.AddRange(PreOrder(root.LeftChild));
            }
            if (root.RightChild != null)
            {
                nodeArray.AddRange(PreOrder(root.RightChild));
            }
            return nodeArray;
        }
    }
}
