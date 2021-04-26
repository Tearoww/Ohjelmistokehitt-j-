using System;

namespace Lukupyramidi
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Write("Hei! Anna jokin luku: ");

            try
            {
                x = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Tapahtui virhe.");
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