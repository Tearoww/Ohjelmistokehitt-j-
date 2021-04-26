using System;

namespace Hedelmätaulukko
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Fruits = { "Ananas", "Mango", "Persikka" };
            int x;
            bool HasReturned = false;

            while (HasReturned == false)
            {
                Console.Write("Montako hedelmää haluat nähdä?");

                try
                {
                    x = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Tapahtui virhe.");
                    return;
                }

                if (x <= 3)
                {
                    for (int i = 0; i < x; i++)
                    {
                        Console.WriteLine(Fruits[i]);
                    }
                    HasReturned = true;
                }
                else if (x > 3)
                {
                    Console.WriteLine("En tiedä noin montaa hedelmää!");
                    Console.WriteLine("Yritä uudelleen painamalla jotain näppäintä.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}