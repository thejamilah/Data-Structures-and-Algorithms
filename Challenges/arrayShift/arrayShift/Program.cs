using System;

namespace arrayShift
{
    public class Program
    {
        public static void Main()
        {
            int[] array = { 2, 4, 6, 8, 9 };
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

        /// <summary>
        /// Insert a number into the middle of an array
        /// </summary>
        /// <param name="array">Given array to insert number</param>
        /// <param name="middleNum">Number to insert into array</param>
        /// <returns></returns>
        public static int[] ArrayShift(int[] array, int middleNum)
        {
            int[] newArray = new int[array.Length + 1];
            int counter = 0;
            //using decimal and Math.Ceiling allows the correct middle index to be located 
            //with an unvenen index length
            decimal midIndex = Math.Ceiling((decimal)(array.Length) / 2);
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

