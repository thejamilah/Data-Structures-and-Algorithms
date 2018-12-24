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
            HashTableArray = new Node[1024];
        }

        public void Add(int value, string key)
        {
            Node node = new Node(value, key);
            int index = GetHash(key);
            if (HashTableArray[index] == null) 
            {
                HashTableArray[index] = node;
            }

            else
            {
                node.Next = HashTableArray[index];
            }

        }

        public int GetHash(string key)
        {
            decimal total = 0;
            foreach (char x in key)
            {
                total += x;
            }

            return (int)Math.Floor((total * 599) / 1024);
        }

        public int FindKey(string key)
        {
            int index = GetHash(key);

            Node current = HashTableArray[index];

            while (current.Next != null)
            {
                if (current.Key == key)
                {
                    return current.Value;
                }

                current = current.Next;                           
            }

            if (current.Key == key)
            {
                return current.Value;
            }

            return 0; 
        }

        public bool Contains(string key)
        {
            int index = GetHash(key);

            Node current = HashTableArray[index];

            while (current.Next != null)
            {
                if (current.Key == key)
                {
                    return true;
                }

                current = current.Next;
            }

            if (current.Key == key)
            {
                return true;
            }

            return false;
        }

    }
}
