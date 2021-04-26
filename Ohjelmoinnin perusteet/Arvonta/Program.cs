using System;

namespace Arvonta
{
    class Program
    {
        static void Main(string[] args)
        {
            int Raffle;
            int x;
            int Turn = 1;
            bool IsWinner = false;

            Random RandomNumber = new Random();

            Raffle = RandomNumber.Next(1, 101);

            while (Turn <= 5)
            {
                if (Turn == 1)
                {
                    Console.Write("Hei! Arvaa ohjelman valitsema kokonaisluku (1-100): ");
                }
                else
                {
                    Console.Write("Väärin! Arvaa uudelleen: ");
                }

                try
                {
                    x = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Tapahtui virhe.");
                    return;
                }

                if (x == Raffle)
                {
                    Console.WriteLine("Onneksi olkoon, sama luku!");
                    IsWinner = true;
                    break;
                }
                Turn++;
            }
            if (Turn >= 5 && IsWinner == false)
            {
                Console.WriteLine("Kierroksia 5, lopetetaan ohjelma.");
            }
        }
    }
}