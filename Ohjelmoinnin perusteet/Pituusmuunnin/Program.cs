using System;

namespace Pituusmuunnin
{
    class Program
    {
        static void Main(string[] args)
        {
            short Height;

            Console.Write("Hei! Kuinka pitkä olet? (cm): ");

            CheckInput:
            try
            {
                Height = short.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Tapahtui virhe.");
                return;
            }
            if (Height <= 272 && Height >= 54)
            {
                float Metres = (float)Math.Round(Height / 100f, 2, MidpointRounding.AwayFromZero);
                decimal Miles = Math.Round(Height / 160934m, 2, MidpointRounding.AwayFromZero);
                float Yards = (float)Math.Round(Height / 91.44f, 2, MidpointRounding.AwayFromZero);
                float Inches = (float)Math.Round(Height / 2.54f, 2, MidpointRounding.AwayFromZero);
                Console.WriteLine("Olet {0} metriä, {1} mailia, {2} jaardia ja {3} tuumaa pitkä.", Metres, Miles, Yards, Inches);
            }
            else
            {
                Console.WriteLine("En usko!");
                Console.Write("Kuinka pitkä OIKEASTI olet? (cm): ");
                goto CheckInput;
            }
        }
    }
}