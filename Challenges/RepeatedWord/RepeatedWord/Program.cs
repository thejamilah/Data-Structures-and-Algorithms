using System;
using System.Collections;

namespace RepeatedWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Repeted Word");
            Console.WriteLine(" ");

            string string1 = "The quick brown fox jumped over the moon";
            
            string string2 = "No rest for the wicked";

            Console.WriteLine(string1);
            Console.WriteLine($"The first word repeated is: {RepeatedWord(string1)}\n");

            Console.WriteLine(string2);
            Console.WriteLine($"The first repeated word is: {RepeatedWord(string2)}\n");

            Console.WriteLine(" ");
            Console.WriteLine("Repeated integers");

            int[] array1 = { 2, 2, 3, 4, 4, 4, 5, 5, 7, 8, 8, 9 };

            int[] array2 = { 2, 3, 4, 5, 6, 7, 8, 9 };

            //Console.WriteLine(array1);
            //Console.WriteLine($"The repeated integer is: {RepeatedInteger(array1)}\n");

            //Console.WriteLine(array2);
            //Console.WriteLine($"The repeated integer is: {RepeatedInteger(array2)}\n");
        }

        public static string RepeatedWord(string input)
        {
            string[] temp = input.ToLower().Split(" ");
            Hashtable table = new Hashtable();

            foreach (string word in temp)

                    if (!table.Contains(word))
                {
                    table.Add(word, word);
                }
                else
                {
                    return word;
                }

            return "There are no repeated words in this string";
        }

    }
}
