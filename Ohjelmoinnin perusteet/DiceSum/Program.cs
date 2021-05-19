using System;

namespace DiceSum
{
    class Program
    {
        /// <summary>
        /// Rolls dice five times and adds the results together
        /// </summary>
        /// <returns>The sum of five dice as an integer</returns>
        private static int RollDice(int RoundAmount)
        {
            Random pool = new Random();
            int sum = 0;

            for (int i = 1; i <= RoundAmount; i++)
                sum += pool.Next(1, 7);
            return sum;
        }

        /// <summary>
        /// Prints the sum of two dice to the user
        /// </summary>
        private static void PrintSum()
        {
            int RoundAmount = AmountOfRounds();
            Console.WriteLine(RollDice(RoundAmount) + RollDice(RoundAmount));
        }

        /// <summary>
        /// Sets the amount of rounds to roll dice
        /// </summary>
        /// <returns>The amount on rounds</returns>

        private static int AmountOfRounds()
        {
            Console.Write("Montako kierrosta noppia heitetään?: ");
            int RoundAmount = SelectionParser();
            return RoundAmount;
        }

        /// <summary>
        /// Parses user selection into integer
        /// </summary>
        /// <returns>A valid integer</returns>
        private static int SelectionParser()
        {
            int selection;
            bool intCheck;
            do{
               intCheck = int.TryParse(Console.ReadLine(), out selection);
            }while(!intCheck);
            return selection;
        }

        static void Main(string[] args)
        {
            PrintSum();
        }
    }
}