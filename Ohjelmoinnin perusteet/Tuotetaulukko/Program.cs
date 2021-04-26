using System;

namespace Tuotetaulukko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int x;

            Console.Write("Montako tuotetta haluat lisätä?: ");

            try
            {
                x = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Tapahtui virhe.");
                return;
            }

            string[] Products = new string[x];
            decimal[] Prices = new decimal[x];
            int[] Amounts = new int[x];

            for (int i = 0; i < x; i++)
            {
                Console.Write("\nAnna {0}. tuotteen nimi: ", i + 1);

                Products[i] = Console.ReadLine();

                Console.Write("\nAnna {0}. tuotteen hinta: ", i + 1);

                try
                {
                    Prices[i] = decimal.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Tapahtui virhe.");
                    return;
                }

                Console.Write("\nAnna {0}. tuotteen lukumäärä: ", i + 1);

                try
                {
                    Amounts[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Tapahtui virhe.");
                    return;
                }

                Console.WriteLine("\n");
            }

            for (int j = 0; j < Products.Length; j++)
            {
                Console.WriteLine("Tuotteen {0} yhteishinta on {1}€.", Products[j], Prices[j] * Amounts[j]);
                Console.Write("\n");
            }
        }
    }
}