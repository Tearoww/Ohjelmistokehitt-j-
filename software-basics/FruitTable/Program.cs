using System;

namespace FruitTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "Pineapple", "Mango", "Peach" };
            int x;
            bool hasReturned = false;

            while (hasReturned == false)
            {
                Console.Write("How many fruits would you like to see?");

                try
                {
                    x = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("An error occurred.");
                    return;
                }

                if (x <= 3)
                {
                    for (int i = 0; i < x; i++)
                    {
                        Console.WriteLine(fruits[i]);
                    }
                    hasReturned = true;
                }
                else if (x > 3)
                {
                    Console.WriteLine("I don't know that many fruits!");
                    Console.WriteLine("Try again by pressing any button.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}