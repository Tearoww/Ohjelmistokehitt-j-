using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x = 0;

            Console.WriteLine("Hi! I will count the sum of integers until it reaches 100.");

            while (x <= 100)
            {
                if (x < 2)
                {
                    Console.Write("\nGive me an integer: ");

                    try
                    {
                        x = x += byte.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occurred.");
                        return;
                    }
                }
                else
                {
                    Console.Write("\nCurrent sum is {0}, give another integer: ", x);

                    try
                    {
                        x = x += byte.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occurred.");
                        return;
                    }
                }
            }

            Console.WriteLine("\nThe sum {0} is greater than 100. Thank you for being here!", x);
        }
    }
}
