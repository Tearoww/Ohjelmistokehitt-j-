using System;

namespace Grade
{
    class Program
    {
        /// <summary>
        /// Asks the user for a grade
        /// </summary>
        /// <returns>Grade as a byte</returns>
        private static byte AskForGrade()
        {
            byte grade = 0;
            bool isNumber = false;

            Console.Write("Hei! Anna arvosana asteikolla 4-10: ");

            while (!isNumber)
            {
                try
                {
                    grade = byte.Parse(Console.ReadLine());

                    if (grade >= 4 && grade <= 10)
                    {
                        isNumber = true;
                    }
                    else
                    {
                        Console.Write("\nLuku on asteikon ulkopuolella! Anna uusi luku: ");
                    }
                }
                catch (FormatException)
                {
                    Console.Write("\nAnna arvosana NUMEROINA: ");
                }
            }

            return grade;
        }
        /// <summary>
        /// Prints a description of the grade to the user
        /// </summary>
        private static void PrintGrade()
        {
            switch (AskForGrade())
            {
                case 4:
                    Console.WriteLine("\n4 on hylätty.");
                    break;
                case 5:
                    Console.WriteLine("\n5 on huono arvosana.");
                    break;
                case 6:
                    Console.WriteLine("\n6 on välttävä arvosana.");
                    break;
                case 7:
                    Console.WriteLine("\n7 on tyydyttävä arvosana.");
                    break;
                case 8:
                    Console.WriteLine("\n8 on hyvä arvosana.");
                    break;
                case 9:
                    Console.WriteLine("\n9 on kiitettävä arvosana.");
                    break;
                case 10:
                    Console.WriteLine("\n10 on erinomainen arvosana.");
                    break;
                default:
                    Console.WriteLine("\nJotain meni pieleen.");
                    Console.ReadKey();
                    Console.Clear();
                    AskForGrade();
                    break;
            }
        }
        static void Main(string[] args)
        {
            PrintGrade();
        }
    }
}