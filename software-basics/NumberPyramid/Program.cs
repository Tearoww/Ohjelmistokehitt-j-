using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Write("Hello! Give me a number: ");

            try
            {
                x = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred.");
                return;
            }

            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
