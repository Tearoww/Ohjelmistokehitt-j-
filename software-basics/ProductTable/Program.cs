using System;

namespace ProductTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int x;

            Console.Write("How many products would you like to add?: ");

            try
            {
                x = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred.");
                return;
            }

            string[] products = new string[x];
            decimal[] prices = new decimal[x];
            int[] amounts = new int[x];

            for (int i = 0; i < x; i++)
            {
                Console.Write("\nName for product {0}: ", i + 1);

                products[i] = Console.ReadLine();

                Console.Write("\nPrice for product {0}: ", i + 1);

                try
                {
                    prices[i] = decimal.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("An error occurred.");
                    return;
                }

                Console.Write("\nAmount of product {0}: ", i + 1);

                try
                {
                    amounts[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("An error occurred.");
                    return;
                }

                Console.WriteLine("\n");
            }

            for (int j = 0; j < products.Length; j++)
            {
                Console.WriteLine("The total price for {0} is {1}€.", products[j], prices[j] * amounts[j]);
                Console.Write("\n");
            }
        }
    }
}
