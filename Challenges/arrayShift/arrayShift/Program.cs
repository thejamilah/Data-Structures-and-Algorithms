using System;

namespace arrayShift
{
    class Program
    {
        public static void Main()
        {
            int[] array = { 2, 4, 6, 8 };
            int middleNum = 5;
            int[] result = ArrayShift(array, middleNum);

            string arrayAsString = "";
            for (int i = 0; i < array.Length; i++)
            {
                arrayAsString = arrayAsString + array[i];
            }

            Console.WriteLine(arrayAsString);

            Console.WriteLine(middleNum);

            string resultString = "";
            for (int i = 0; i < result.Length; i++)
            {
                resultString = resultString + result[i];
            }

            Console.WriteLine(resultString);


        }

        public static int[] ArrayShift(int[] array, int middleNum)
        {
            int[] newArray = new int[array.Length + 1];
            int counter = 0;
            int midIndex = (array.Length / 2);
            for (int i = 0; i < newArray.Length; i++)
            {
                if (midIndex == i)
                {
                    newArray[i] = middleNum;
                }
                else
                {
                    newArray[i] = array[counter++];
                }
            }
            return newArray;

        }
    }
}

