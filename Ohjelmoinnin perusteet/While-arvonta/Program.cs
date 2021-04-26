using System;

namespace While_arvonta
{
    class Program
    {
        static void Main(string[] args)
        {
            int Raffle = 45;
            int x;
            bool IsWinner = false;
            string Exit;
            
            Console.Write("Arvaa ohjelman valitsema numero: ");

            try
            {
                x = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Tapahtui virhe.");
                return;
            }

            while (!IsWinner)
            {
                if (x == Raffle)
                {
                    Console.WriteLine("Onneksi olkoon, osuit oikeaan!");
                    IsWinner = true;
                }
                else
                {
                    Console.Write("Väärin! (L)opeta tai arvaa uudelleen: ");

                    Exit = Console.ReadLine();

                    if (Exit.Contains("L", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("Kiitos ohjelman käytöstä!");
                        return;
                    }
                    else
                    {
                        try
                        {
                            x = int.Parse(Exit);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Tapahtui virhe.");
                            return;
                        }
                    }
                }
            }
        }
    }
}