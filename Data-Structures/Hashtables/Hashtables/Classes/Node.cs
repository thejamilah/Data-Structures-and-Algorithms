using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class Node
    {
        public Node Next { get; set; }

        public string Key { get; set; }

        public int Value { get; set; }


        public Node(int value, string key)
        {
            Value = value;

            Key = key;

            Next = null;
        }
    }
}
