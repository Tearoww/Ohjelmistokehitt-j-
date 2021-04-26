using System;

namespace Valuuttalaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            float eur;
            string Currency;
            
            Console.Write("Hei! Anna jokin rahamäärä euroina: ");

            try
            {
                eur = float.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Tapahtui virhe.");
                return;
            }

            Console.Write("Haluatko muuntaa antamasi summan dollareiksi vai punniksi? (Lyhenne tai merkki): ");
            
            Currency = Console.ReadLine();

            if (Currency == "USD" || Currency == "usd" || Currency == "$")
            {
                float usd = (float)Math.Round(eur * 1.19f, 2, MidpointRounding.AwayFromZero);
                Console.WriteLine("{0}€ on yhtä kuin ${1}.", eur, usd);
            }
            else if (Currency == "GBP" || Currency == "gbp" || Currency == "£")
            {
                float gbp = (float)Math.Round(eur * 0.86f, 2, MidpointRounding.AwayFromZero);
                Console.WriteLine("{0}€ on yhtä kuin £{1}.", eur, gbp);
            }
            else
            {
                Console.WriteLine("Tapahtui virhe.");
                return;
            }
        }
    }
}
