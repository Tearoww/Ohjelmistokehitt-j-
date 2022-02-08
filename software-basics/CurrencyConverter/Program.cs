using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            float eur;
            string currency;
            
            Console.Write("Hi! Give an amount of cash in euros: ");

            try
            {
                eur = float.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred.");
                return;
            }

            Console.Write("Do you want to convert to dollars or pounds? (abbreviation or sign): ");
            
            currency = Console.ReadLine();

            if (currency == "USD" || currency == "usd" || currency == "$")
            {
                float usd = (float)Math.Round(eur * 1.19f, 2, MidpointRounding.AwayFromZero);
                Console.WriteLine("{0}€ equals ${1}.", eur, usd);
            }
            else if (currency == "GBP" || currency == "gbp" || currency == "£")
            {
                float gbp = (float)Math.Round(eur * 0.86f, 2, MidpointRounding.AwayFromZero);
                Console.WriteLine("{0}€ equals £{1}.", eur, gbp);
            }
            else
            {
                Console.WriteLine("An error occurred.");
                return;
            }
        }
    }
}
