using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search - Sorted Data");

            int[] inputData = new int[] { 1, 2, 3, 7, 19, 22, 31, 39, 40, 58 };

            Console.WriteLine("Please enter search value as a whole integer:");
            int searchValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Integer value found at index else -1 returned if not found: " + BinarySearch(inputData, searchValue));
        }

        public static int BinarySearch(int [] inputData, int searchValue)
        {
            int midIndex;
            int leftIndex = 0;
            int rightIndex = inputData.Length - 1;

            while (leftIndex <= rightIndex)
            {
                midIndex = leftIndex + ((rightIndex - leftIndex) / 2);

                if (inputData[midIndex] == searchValue)
                {
                    return midIndex;
                }
                else
                {
                    if (inputData[midIndex] > searchValue)
                    {
                        rightIndex = midIndex - 1;
                    }
                    else
                    {
                        leftIndex = midIndex + 1;
                    }
                }
            }

            return -1;
        }
    }
}
