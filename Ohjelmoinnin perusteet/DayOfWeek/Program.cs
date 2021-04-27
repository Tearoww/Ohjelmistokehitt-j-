using System;

namespace DayOfWeek
{
    class Program
    {
        /// <summary>
        /// Asks the user which day of the week it is
        /// </summary>
        /// <returns>Day as a byte</returns>
        private static byte AskForDay()
        {
            byte day = 0;
            bool isNumber = false;

            Console.Write("Hei! Monesko päivä viikosta nyt on? (1-7): ");

            while (!isNumber)
            {
                try
                {
                    day = byte.Parse(Console.ReadLine());

                    if (day > 0 && day <= 7)
                    {
                        isNumber = true;
                    }
                    else
                    {
                        Console.Write("\nAnnoit liian pienen tai suuren luvun! Monesko päivä viikosta nyt on? (1-7): ");
                    }
                }
                catch (FormatException)
                {
                    Console.Write("\nAnna päivä LUKUNA: ");
                }
            }

            return day;
        }
        /// <summary>
        /// Prints the name of the day to the user
        /// </summary>
        private static void PrintDay()
        {
            switch (AskForDay())
            {
                case 1:
                    Console.WriteLine("\nHyvää maanantaita!");
                    break;
                case 2:
                    Console.WriteLine("\nHyvää tiistaita!");
                    break;
                case 3:
                    Console.WriteLine("\nHyvää keskiviikkoa!");
                    break;
                case 4:
                    Console.WriteLine("\nHyvää torstaita!");
                    break;
                case 5:
                    Console.WriteLine("\nHyvää perjantaita!");
                    break;
                case 6:
                    Console.WriteLine("\nHyvää lauantaita!");
                    break;
                case 7:
                    Console.WriteLine("\nHyvää sunnuntaita!");
                    break;
                default:
                    Console.WriteLine("\nJotain meni pieleen.");
                    Console.ReadKey();
                    Console.Clear();
                    AskForDay();
                    break;
            }
        }
        static void Main(string[] args)
        {
            PrintDay();
        }
    }
}