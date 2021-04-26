using System;

namespace Summa
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x = 0;

            Console.WriteLine("Hei! Lasken antamiesi kokonaislukujen summan, kunnes se on yli 100.");

            while (x <= 100)
            {
                if (x < 2)
                {
                    Console.Write("\nAnna kokonaisluku: ");

                    try
                    {
                        x = x += byte.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Tapahtui virhe.");
                        return;
                    }
                }
                else
                {
                    Console.Write("\nSumma tällä hetkellä {0}, anna seuraava kokonaisluku: ", x);

                    try
                    {
                        x = x += byte.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Tapahtui virhe.");
                        return;
                    }
                }
            }

            Console.WriteLine("\nSumma {0} on suurempi kuin 100. Kiitos, että käytit ohjelmaa!", x);
        }
    }
}