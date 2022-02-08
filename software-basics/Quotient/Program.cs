using System;

namespace Quotient
{
    class Program
    {
        static void Main(string[] args)
        {
            int divident = 0, divider = 0, quotient;
            bool isNumber = false;

            Console.Write("Hei! Lasken osamääriä. Anna jaettava: ");

            while (!isNumber)
            {
                try
                {
                    divident = int.Parse(Console.ReadLine());

                    isNumber = true;
                }
                catch (FormatException)
                {
                    Console.Write("\nAnna jaettava NUMERONA: ");
                }
            }

            Console.Write("\nKiitos. Anna vielä jakaja: ");

            isNumber = false;

            while (!isNumber)
            {
                try
                {
                    divider = int.Parse(Console.ReadLine());

                    if (divider == 0)
                    {
                        Console.Write("\nNollalla ei voi jakaa! Anna uusi numero: ");
                    }
                    else
                    {
                        isNumber = true;
                    }
                }
                catch (FormatException)
                {
                    Console.Write("\nAnna jakaja NUMERONA: ");
                }
            }
            quotient = divident / divider;

            Console.WriteLine("\nLukujen {0} ja {1} osamäärä on {2}.", divident, divider, quotient);

            Console.WriteLine("\nKiitos ohjelman käytöstä!");
        }
    }
}