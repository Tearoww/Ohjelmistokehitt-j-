using System;

namespace WhileRaffle
{
    class Program
    {
        static void Main(string[] args)
        {
            int raffle = 45;
            int x;
            bool isWinner = false;
            string exit;
            
            Console.Write("Guess the number chosen by the program: ");

            try
            {
                x = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred.");
                return;
            }

            while (!isWinner)
            {
                if (x == raffle)
                {
                    Console.WriteLine("Congratulations, you guessed it!");
                    isWinner = true;
                }
                else
                {
                    Console.Write("Wrong! (E)xit or guess again: ");

                    exit = Console.ReadLine();

                    if (exit.Contains("E", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("Thanks for trying!");
                        return;
                    }
                    else
                    {
                        try
                        {
                            x = int.Parse(exit);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("An error occurred.");
                            return;
                        }
                    }
                }
            }
        }
    }
}
