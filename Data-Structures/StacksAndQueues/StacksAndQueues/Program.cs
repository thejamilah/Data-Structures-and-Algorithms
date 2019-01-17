using StacksQueues.Classes;
using System;

namespace StacksQueues
{
    public class Program
    {
        static void Main(string[] args)
        {   
            //using statement StacksQueues.Classes added for access to Node
            //Instantiating nodes
            Console.WriteLine("Stacks and Queues");
            Node inputNode1 = new Node(100);
            Node inputNode2 = new Node(200);
            Node inputNode3 = new Node(300);
            Node inputNode4 = new Node(400);
            Node inputNode5 = new Node(500);
            Queue theQueue = new Queue(inputNode1);
            theQueue.Enqueue(inputNode2);
            theQueue.Enqueue(inputNode3);
            theQueue.Enqueue(inputNode4);
            theQueue.Enqueue(inputNode5);

            //Console write lines below display node values for peek and dequeued nodes
            Console.WriteLine("Queue:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Peek #{i}: ");
                Console.WriteLine($"{theQueue.Peek().Value}");

                Node removedNode = theQueue.Dequeue();
                Console.WriteLine(removedNode.Value);

            }

            //Instantiating stack with inout node values
            Stack theStack = new Stack(inputNode1);
            theStack.Push(inputNode2);
            theStack.Push(inputNode3);
            theStack.Push(inputNode4);
            theStack.Push(inputNode5);
            Console.WriteLine("==========");
            Console.WriteLine("Stack:");

            Console.WriteLine($"First peek: {theStack.Peek().Value}");
            theStack.Pop();
            Console.WriteLine($"Second peek: {theStack.Peek().Value}");
            theStack.Pop();
            Console.WriteLine($"Third peek: {theStack.Peek().Value}");
            theStack.Pop();
            Console.WriteLine($"Fourth peek: {theStack.Peek().Value}");
            theStack.Pop();
            Console.WriteLine($"Fifth peek: {theStack.Peek().Value}");
            theStack.Pop();
        }
    }
}
