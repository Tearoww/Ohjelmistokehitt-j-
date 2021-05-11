using System;

namespace DiceSum
{
    class Program
    {
        /// <summary>
        /// Rolls dice five times and adds the results together
        /// </summary>
        /// <returns>The sum of five dice as an integer</returns>
        private static int RollDice()
        {
            Random pool = new Random();
            int[] results = new int[5];
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                results[i] = pool.Next(1, 7);
            }

            for (int i = 0; i < results.Length; i++)
            {
                sum += (int)results.GetValue(i);
            }

            return sum;
        }
        /// <summary>
        /// Prints the sum of two dice to the user
        /// </summary>
        private static void PrintSum()
        {
            Console.WriteLine(RollDice() + RollDice());
        }
        static void Main(string[] args)
        {
            PrintSum();
        }
    }
}