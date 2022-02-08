using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int sum = 0;
            int average = 0;
            
            Console.WriteLine("Hello! I calculate the average of integers given by you.");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Give me a number {0}/5: ", i + 1);

                try
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("An error occurred.");
                    return;
                }
            }

            foreach (int Number in numbers)
            {
                sum = sum += Number;
                average = sum / numbers.Length;
            }

            Console.WriteLine("The average of your numbers is {0}.", average);
        }
    }
}
