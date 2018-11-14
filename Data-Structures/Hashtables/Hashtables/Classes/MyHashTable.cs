using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class MyHashTable
    {
        public Node[] HashTableArray { get; set; }

        public MyHashTable()
        {
            HashTableArray = new Node[1000];
        }

        public void Add(int value, string key)
        {
            Node node = new Node(value, key);
            int index = GetHash(key);
            if (HashTableArray[index] != null) 
            {
                HashTableArray[index] = node;
            }

            else
            {
                node.Next = HashTableArray[index];
            }

        }
    }
}
