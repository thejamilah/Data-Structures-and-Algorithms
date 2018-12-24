using System;

namespace BinaryTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree");

            BinarySearchTree tree1 = new BinarySearchTree();
            tree1.add(100);
            tree1.add(90);
            tree1.add(80);
            tree1.add(70);
            tree1.add(60);
            tree1.add(50);

            Console.ReadLine();
        }
    }
}
