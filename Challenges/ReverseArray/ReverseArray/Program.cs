using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse an Array");
            Console.WriteLine(" ");
            ReverseArray1();
            ReverseArray2();
        }

        /// <summary>
        /// Reveres an array with the instatiation of a new array creating additional space 
        /// Time: O (n) for the iteration of the array n times
        /// Space: O (n) Additional space is create/insertion of array for the length of the new array
        /// </summary>
        static void ReverseArray1()
        {
            //hard coded input string
            string[] locations = { "alki beach", "capital hill", "queene anne", "belltown" };

            Console.WriteLine("Input array 1:");
            foreach (string i in locations)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(" ");

            //instatiate new array adds additional space
            string[] reversed = new string[locations.Length];

            //intatiate counter
            int counter = 0;

            //iterate string with for loop for (variable initialization; condition; steps)
            for(int i = locations.Length-1; i >= 0; i--)
            {
                reversed[counter] = locations[i];
                counter++;
            }

            Console.WriteLine("This is the reverese if input array 1 using brute force:");

            foreach (string item in reversed)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Reverse an array in place with Time: O(log n) Space: O (1)
        /// </summary>
        static void ReverseArray2()
        {
            //hard coded input array
            int[] inputArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(" ");
            Console.WriteLine("Input array 2:");

            //use foreach to print input array to console
            foreach (int j in inputArray)
            {
                Console.WriteLine(j);
            }

            int temp;

            //reversed the array in place
            for(int i = 0; i < inputArray.Length / 2; i++)
            {
                temp = inputArray[inputArray.Length -1 -i];
                inputArray[inputArray.Length - 1 - i] = inputArray[i];
                inputArray[i] = temp;
            }

            Console.WriteLine(" ");
            Console.WriteLine("This is the result of the reversed input array 2 in place:");

            //Use a for each to iterate through and print out each element in array to the console; the method written is void and has no return type
            foreach (int k in inputArray)
            {
                Console.WriteLine(k);
            }
        }
    }
}
