using System;
using System.Collections.Generic;
using System.Text;

namespace StacksQueues.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        public Stack(Node node)
        {
            //There's only one node in a stack 
            Top = node;
        }

        //Three methods Peek, Pop, Push

        //Peek needs a return and it will return the Top in a stack
        public Node Peek()
        {
            return Top;
            //can console write line .value to return the value of peek 
        }

        //Pop
        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            //clean up pointer 
            temp.Next = null;
            return temp;
        }

        //Push; data type is void, we aren't returning a value because we are pushing a node
        public void Push(Node node)
        {
            //if we have a node coming in the pointer needs to be redirected
            node.Next = Top;
            Top = node;

        }
    }

}
