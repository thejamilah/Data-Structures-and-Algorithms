using System;

namespace arrayShift
{
    public class Program
    {
        public static void Main()
        {
            decimal[] array = { 2, 4, 6, 8, 9 };
            decimal middleNum = 5;
            decimal[] result = ArrayShift(array, middleNum);

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

        public static decimal[] ArrayShift(decimal[] array, decimal middleNum)
        {
            decimal[] newArray = new decimal[array.Length + 1];
            int counter = 0;
            decimal midIndex = (decimal) Math.Ceiling((decimal)(array.Length) / 2);
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

