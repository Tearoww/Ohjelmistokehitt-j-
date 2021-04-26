using System;

namespace Keskiarvo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[5];
            int Sum = 0;
            int Average = 0;
            
            Console.WriteLine("Hei! Lasken antamistasi kokonaisluvuista keskiarvon.");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Anna luku {0}/5: ", i + 1);

                try
                {
                    Numbers[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Tapahtui virhe.");
                    return;
                }
            }

            foreach (int Number in Numbers)
            {
                Sum = Sum += Number;
                Average = Sum / Numbers.Length;
            }

            Console.WriteLine("Lukujen keskiarvo on {0}.", Average);
        }
    }
}