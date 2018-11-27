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

            Console.WriteLine(" ");

            Console.WriteLine("This is an unsorted array:");
            
            foreach (int x in inputArray)
            {
                Console.Write($"{x} ");
            }

            Console.WriteLine("\n ");

            Console.WriteLine("This is the Insertion Sort Method Result:");

            InsertionSort(inputArray);
            foreach (int y in inputArray)
            {
                Console.Write($"{y} ");
            }

            Console.WriteLine("\n ");

            Console.WriteLine("==================================================");

            Console.WriteLine("\n ");

            Console.WriteLine("This is an unsorted array:");

            Console.WriteLine("\n ");

            int[] inputArray2 = { 9, 3, 22, 1, 43, 32, 94, 79, 100 };

            foreach (int y in inputArray2)
            {
                Console.Write($"{y} ");
            }

            Console.WriteLine("\n ");

            Console.WriteLine("This is the result of the Quick Sort Method:");

            QuickSort(inputArray2, 0, inputArray2.Length - 1);

            Console.WriteLine("\n ");

            Console.WriteLine("This is an unsorted array:");

            Console.WriteLine("\n ");

            int[] inputArray3 = { 134, 22, 71, 84, 1, 9, 18, 31, 4 };


            foreach (int z in inputArray3)
            {
                Console.Write($"{z} ");
            }

            MergeSort(inputArray3);

            Console.WriteLine("\n ");

            Console.WriteLine("This is the result of the Merge Sort Method:");
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

        /// <summary>
        /// Quick Sort
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int position = Partition(arr, left, right);

                QuickSort(arr, left, position - 1);

                QuickSort(arr, position + 1, right);

            }
        }

        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];

            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }
            }

            Swap(arr, right, low + 1);

            Console.WriteLine(string.Join(",", arr));

            return low + 1;
        }

        static void Swap(int[] arr, int i, int low)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }

        /// <summary>
        /// Merge Sort
        /// </summary>
        /// <param name="inputArray3"></param>
        static void MergeSort(int[] inputArray3)
        {
            if(inputArray3.Length > 1)
            {
                int leftSize = inputArray3.Length / 2;
                int rightSize = inputArray3.Length - leftSize;

                int[] left = new int[leftSize];
                Array.Copy(inputArray3, 0, left, 0, leftSize);

                int[] right = new int[rightSize];
                Array.Copy(inputArray3, inputArray3.Length / 2, right, 0, rightSize);

                MergeSort(left);
                MergeSort(right);
                Merge(left, right, inputArray3);
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

