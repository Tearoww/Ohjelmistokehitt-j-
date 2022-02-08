using System;

namespace Raffle
{
    class Program
    {
        static void Main(string[] args)
        {
            int raffle;
            int x;
            int turn = 1;
            bool isWinner = false;

            Random RandomNumber = new Random();

            raffle = RandomNumber.Next(1, 101);

            while (turn <= 5)
            {
                if (turn == 1)
                {
                    Console.Write("Hello! Guess the program's chosen integer (1-100): ");
                }
                else
                {
                    Console.Write("Wrong! Guess again: ");
                }

                try
                {
                    x = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("An error occurred.");
                    return;
                }

                if (x == raffle)
                {
                    Console.WriteLine("Congratulations, you guessed it!");
                    isWinner = true;
                    break;
                }
                turn++;
            }
            if (turn >= 5 && isWinner == false)
            {
                Console.WriteLine("Five turns reached, stopping..");
            }
        }
    }
}
