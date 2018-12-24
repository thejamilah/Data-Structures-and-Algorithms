using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    class LinkedList
    {
        /// <summary>
        ///        Head always points to the first node in the linked list
        /// </summary>
        public Node Head { get; set; }

        /// <summary>
        ///        Setting current note to traverse (move through) the linked list
        /// </summary>
        public Node Current { get; set; }

        /// <summary>
        ///        This is the process of creating a new head each time you traverse 
        /// </summary>
        /// <param name="node">the node that will become the head; assigning a new head for node</param>
        public LinkedList(Node node)
        {
            Head = node;
            Current = node;
        }

        /// <summary>
        /// Add a node to the beginning of the linked list; notes from calss lecture indicates that this is sometimes called Insert
        /// time: O(1)
        /// space: O(1) why? because performing insertions or deletions
        /// </summary>
        /// <param name="node">the node that will be added</param>
        public void Add(Node node)
        {
            Current = Head;
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        /// <summary>
        ///    Prints the list node by node to the console
        ///    time: O(n)
        ///    space: O(1) why you have inserted a new node 
        /// </summary>
        public void Print()
        {
            Current = Head;

            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} --> ");
                Current = Current.Next;
            }

            Console.Write($"{Current.Value} --> NULL\n");
            Current = Head;
        }


        /// <summary>
        /// Appends a node to the end of the linked list; aka add after method
        /// time: O(n)
        /// space: O(1)
        /// </summary>
        /// <param name="newNode">the node to be added</param>
        public void Append(Node newNode)
        {
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            Current.Next = newNode;
            Current = Head;
        }

        /// <summary>
        /// inserts a node into the list before a given node
        /// time: O(n)
        /// space: O(1)
        /// </summary>
        /// <param name="newNode">the node to be added</param>
        /// <param name="existingNode">the node that will follow the newly added node</param>
        public void AddBefore(Node newNode, Node existingNode)
        {
            Current = Head;
            if (Head.Value == existingNode.Value)
            {
                Add(newNode);
                return;
            }

            while (Current.Next != null)
            {
                if (Current.Next.Value == existingNode.Value)
                {
                    newNode.Next = existingNode;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
        }
    }
}

