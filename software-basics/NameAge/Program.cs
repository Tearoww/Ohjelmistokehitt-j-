using System;

namespace NameAge
{
    class Program
    {
        private enum Menu
        {
            Exit, SaveName, SaveAge, ShowName, ShowAge
        }
        private static byte counter = 0;
        /// <summary>
        /// Prints menu items to the user and handles selection
        /// </summary>
        /// <returns>Selection as an enumeration</returns>
        private static Menu Handler()
        {
            bool isNumber = false;
            byte selection = 127;

            if (counter == 0)
            {
                Console.WriteLine("Hei! Siirry valikossa valitsemalla numero.\n");
            }
            else
            {
                Console.WriteLine("\nSiirry valikossa valitsemalla numero.\n");
            }

            Console.WriteLine("0. Poistu ohjelmasta");
            Console.WriteLine("1. Syötä nimesi");
            Console.WriteLine("2. Syötä syntymäaikasi");
            Console.WriteLine("3. Näytä nimesi");
            Console.WriteLine("4. Näytä ikäsi");
            Console.Write("\n> ");

            while (!isNumber)
            {
                try
                {
                    selection = byte.Parse(Console.ReadLine());

                    if (selection >= 0 && selection <= 4)
                    {
                        isNumber = true;
                    }
                    else
                    {
                        Console.Write("\nValintaasi ei löydy valikosta! Valitse uudelleen: ");
                    }
                }
                catch (FormatException)
                {
                    Console.Write("\nAnna valintasi NUMERONA: ");
                }
            }

            counter++;

            return (Menu)selection;
        }
        /// <summary>
        /// Calculates age from the user's birthday
        /// </summary>
        /// <param name="birthDate"></param>
        /// <returns>The user's age as a byte</returns>
        private static double AgeCalculator(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Today;
            TimeSpan age = currentDate - birthDate;
            double calculatedAge;

            if (age.TotalDays == 365)
            {
                calculatedAge = Math.Round(age.TotalDays / 365, 0, MidpointRounding.ToZero);
            }
            else
            {
                calculatedAge = Math.Round(age.TotalDays / 365.25, 0, MidpointRounding.ToZero);
            }

            return calculatedAge;
        }
        /// <summary>
        /// Saves or prints data from or to the user
        /// </summary>
        private static void Table()
        {
            bool exit = false;
            string name = "";
            DateTime birthDate = DateTime.MinValue;
            
            while (!exit)
            {
                switch (Handler())
                {
                    case Menu.Exit:
                        exit = true;
                        Console.WriteLine("\nKiitos ohjelman käytöstä!");
                        break;
                    case Menu.SaveName:
                        Console.Write("\nAnna nimesi: ");
                        name = Console.ReadLine();
                        Console.WriteLine("\nNimesi on tallennettu.");
                        break;
                    case Menu.SaveAge:
                        Console.Write("\nAnna syntymäaikasi: ");
                        while (!DateTime.TryParse(Console.ReadLine(), out birthDate))
                        {
                            Console.Write("\nAnna syntymäpäiväsi muodossa PP.KK.VVVV:");
                        }
                        Console.WriteLine("\nSyntymäpäiväsi on tallennettu.");
                        break;
                    case Menu.ShowName:
                        Console.WriteLine("\nNimesi on {0}.", name);
                        break;
                    case Menu.ShowAge:
                        Console.WriteLine("\nOlet {0} vuotta vanha.", AgeCalculator(birthDate));
                        break;
                    default:
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Table();
        }
    }
}