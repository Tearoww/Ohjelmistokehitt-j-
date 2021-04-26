using System;

namespace Laskeminen
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

            Console.Write("Anna numero väliltä 0-10: ");

            do
            {
                try
                {
                    y = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Tapahtui virhe.");
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
                    Console.WriteLine("Annoit sopimattoman numeron!");
                    Console.Write("Anna numero väliltä 0-10: ");
                }
            } while (true);
        }
    }
}