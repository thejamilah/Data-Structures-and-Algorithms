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

        static void MergeSort(int[] inputArray)
        {
            if(inputArray.Length > 1)
            {
                int leftSize = inputArray.Length / 2;
                int rightSize = inputArray.Length - leftSize;

                int[] left = new int[leftSize];
                Array.Copy(inputArray, 0, left, 0, leftSize);

                int[] right = new int[rightSize];
                Array.Copy(inputArray, 0, right, 0, rightSize);

                MergeSort(left);
                MergeSort(right);
                Merge(left, right, inputArray);
            }
        }

        static int[] Merge(int[] left, int[] right, int[] arr)
        {
            int i = 0;

            int j = 0;

            int k = 0;

            while (i < left.Length && j < right.Length)
            {
                if(left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            if(i == left.Length)
            {
                Array.Copy(right, j, arr, k, right.Length - j);
            }

            else
            {
                Array.Copy(left, i, arr, k, left.Length - i);
            }

            return arr;

        }
    }
}

