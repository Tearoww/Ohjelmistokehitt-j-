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
        /// Asks the user for number of throws and prints their sum
        /// </summary>
        private static void PrintSum()
        {
            byte numberOfThrows = 0;
            bool isNumber = false;

            Console.Write("Hei! Kuinka monta kertaa haluat heittää viittä noppaa?: ");

            while (!isNumber)
            {
                try
                {
                    numberOfThrows = byte.Parse(Console.ReadLine());

                    isNumber = true;
                }
                catch (FormatException)
                {
                    Console.Write("\nAnna määrä NUMERONA: ");
                }
                catch (OverflowException)
                {
                    Console.Write("\nAnna jokin sopivampi luku: ");
                }
            }

            Console.WriteLine();

            for (int i = 0; i < numberOfThrows; i++)
            {
                Console.WriteLine(RollDice() + RollDice());
            }
        }
        static void Main(string[] args)
        {
            PrintSum();
        }
    }
}