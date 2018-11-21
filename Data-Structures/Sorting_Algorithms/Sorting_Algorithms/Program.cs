using System;

namespace Sorting_Algorithms
        //Algorithm:
        //You will need a for loop for the outside to iterate through the list as a whole
        //Temp variable is going to hold the current value of the index of the array[i]
        //Create a new counter (j) one position less than the index of the for loop tp determine if temp is less than the position of j
        //create a while loop: while j is equal to or greater than zero AND the value of temp is less than the position of j
        //"move" the value of j over one position
        //decrement j back one position
        //
        //when out of the while loop, two things are possible 
        //*The code will be at the beginning of the list
        //* Position of array [j] is less than temp, we know where our temp needs to be inserted, insert the value
        //increment our for loop


{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting Algorithms");

            int[] inputArray = new int[] { 15, 7, 8, 12, 32, 77};

            Console.WriteLine("This is an unsorted array:");
            foreach (int x in inputArray)
            {
                Console.Write($"{x} ");
            }

            Console.WriteLine("This is the Insertion Sort Method Result:");

            InsertionSort(inputArray);
            foreach (int y in inputArray)
            {
                Console.Write($"{y} ");
            }
        }

        /// <summary>
        /// Insertion Sort method sorts a given array of integers
        /// </summary>
        /// <param name="inputArray"></param>
        static void InsertionSort(int[] inputArray)
        {
            for (int i = 1; i < inputArray.Length; i++)
            {
                int temp = inputArray[i];
                int j = i - 1;

                while (j >= 0 && temp < inputArray[j])
                {
                    inputArray[j + 1] = inputArray[j];
                    j--;
                }

                inputArray[j + 1] = temp;
            }

        }
    }
}

