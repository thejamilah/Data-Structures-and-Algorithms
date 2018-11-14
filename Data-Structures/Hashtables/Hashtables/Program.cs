using System;
using System.Collections;

namespace Hashtables
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Hashtables");
            InstaHashtable();
            Console.ReadLine();
            //add(key, "value")
            //you're adding a object key and an object=item/value for the hash function
        }
        public static void InstaHashtable()
        {
            Hashtable myTable = new Hashtable();

            myTable.Add(5, "please");
            myTable.Add(10, "cat");
            myTable.Add(20, "in");
            myTable.Add(30, "the");
            myTable.Add(40, "hat");
            myTable.Add(42, "asleep");
            myTable.Add(50, "olive");
            myTable.Add(60, "ilove");

            for (int i = 0; i < myTable.HashTableArray.Length; i++)
            {
                if (myTable.HashTableArray[i] != null)
                {
                    Console.WriteLine();
                }
            }
       
        }
    }
}
