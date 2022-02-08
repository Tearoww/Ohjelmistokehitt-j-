using System;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i + " * " + x + " = " + (i * x) + "\t" + i + " / " + x + " = " + (i / x) + "\t" + i + " % " + x + " = " + (i % x));
            }

            Console.Write("Give me a number between 0-10: ");

            do
            {
                try
                {
                    y = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("An error occurred.");
                    return;
                }
                if (y <= 10 && y >= 0)
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        Console.WriteLine(i + " * " + y + " = " + (i * y) + "\t" + i + " / " + y + " = " + (i / y) + "\t" + i + " % " + y + " = " + (i % y));
                    }
                }
                else
                {
                    Console.WriteLine("You gave an unsuitable number!");
                    Console.Write("Give a number between 0-10: ");
                }
            } while (true);
        }
    }
}
