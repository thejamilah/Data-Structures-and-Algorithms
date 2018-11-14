using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class Hashtable
    {
        public Node[] HashTableArray { get; set; }

        public Hashtable()
        {
            HashTableArray = new Node[1000];
        }
    }
}
