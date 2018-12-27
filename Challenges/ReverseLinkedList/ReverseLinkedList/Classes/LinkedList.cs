using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseLinkedList.Classes
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public Node Current { get; set; }

        public LinkedList(Node node)
        {
            Head = node;
            Current = Head;
        }

        public void Add(Node node)
        {
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        public void Print()
        {
            Current = Head;
            while (Current.Next != null)
            {
                Console.WriteLine($"{Current.Value} -->");
            }

            Console.WriteLine($"{Current.Value} --> NULL");
        }

        public void Append(Node newNode)
        {
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = newNode;
        }

        public void AddBefore(Node newNode, Node existingNode)
        {
            Current = Head;
            if (Head.Value == existingNode.Value)
            {
                Add(newNode);
            }
            while (Current.Next != null)
            {
                if(Current.Next.Value == existingNode.Value)
                {
                    newNode.Next = existingNode;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
        }

        public Node Find(object value)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Next == value)
                {
                    return Current;
                }
                Current = Current.Next;
            }

            return (Current.Value).ToString() == value.ToString() ? Current : null;
        }

        public void AddAfter(Node newNode, Node existingNode)
        {
            Current = Head;

            while (Current != null)
            {
                if (existingNode.Value == Current.Value)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
        }

    }
}
