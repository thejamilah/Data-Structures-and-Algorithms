using System;

namespace PrintGrid
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Grid");
            OutputGrid();

        }

        public static void OutputGrid()
        {
            for (int r = 1; r <=5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    Console.Write(r * c);
                }

                Console.WriteLine();
            }
        }

    }

}
