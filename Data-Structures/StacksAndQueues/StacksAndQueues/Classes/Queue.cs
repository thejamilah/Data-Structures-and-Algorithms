using System;
using System.Collections.Generic;
using System.Text;
using static StacksQueues.Classes.Stack;

namespace StacksQueues.Classes
{
    public class Queue
    {
        //Properties
        public Node Front { get; set; }
        public Node Rear { get; set; }

        //Constructor; pass in node
        public Queue(Node node)
        {
            Front = node;
            Rear = node;
            //only node; there is no next
        }

        //Three queue methods; example email; first in first out; first come first serve; you do not know how many things you have in a queue, you can't traverse a queue; you can't put anything in the middle of a queue (no cut-sies at the taco stand)

        //Peek
        public Node Peek()
        {
            //Peeking at the front of the queue returns front node
            return Front;
        }

        //Enqueue
        public void Enqueue(Node node)
        {
            //set the reference point 
            Rear.Next = node;
            Rear = node;
        }

        //Dequeue; not passing anything in
        public Node Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }
    }
}
