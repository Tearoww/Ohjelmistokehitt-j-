using System;

namespace Ikälaskuri
{
    class Program
    {
        static void Male()
        {
            byte Age;

            Console.Write("Antaisitko vielä ikäsi: ");

            try
            {
                Age = byte.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Tapahtui virhe.");
                return;
            }

            if (Age <= 13)
            {
                Console.WriteLine("Mitä poitsu");
            }
            else if (Age > 13 && Age < 26)
            {
                Console.WriteLine("Mitä nuorimies");
            }
            else if (Age > 25 && Age < 57)
            {
                Console.WriteLine("Olet mies parhaassa iässä");
            }
            else
            {
                Console.WriteLine("Olet kunnioitettavassa iässä");
            }
        }
        static void Female()
        {
            byte Age;

            Console.Write("Antaisitko vielä ikäsi: ");

            try
            {
                Age = byte.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Tapahtui virhe.");
                return;
            }

            if (Age <= 13)
            {
                Console.WriteLine("Mitä tytsy");
            }
            else if (Age > 13 && Age < 26)
            {
                Console.WriteLine("Mitä nuori neiti");
            }
            else if (Age > 25 && Age < 57)
            {
                Console.WriteLine("Olet nainen parhaassa iässä");
            }
            else
            {
                Console.WriteLine("Olet kunnioitettavassa iässä");
            }
        }
        static void Main(string[] args)
        {
            string Gender;

            Console.Write("Hei! Oletko mies vai nainen? ");

            try
            {
                Gender = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Tapahtui virhe.");
                return;
            }

            if (Gender == "mies" || Gender == "Mies")
            {
                Male();
            }
            else if (Gender == "nainen" || Gender == "Nainen")
            {
                Female();
            }
            else
            {
                Console.WriteLine("Tapahtui virhe.");
                return;
            }
        }
    }
}