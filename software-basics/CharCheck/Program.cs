using System;

namespace CharCheck
{
    class Program
    {
        /// <summary>
        /// Asks the user for a character
        /// </summary>
        /// <returns>User's input as a char</returns>
        private static char AskForChar()
        {
            ConsoleKeyInfo input;
            char c;

            Console.Write("Hei! Anna jokin merkki: ");

            input = Console.ReadKey();
            c = input.KeyChar;

            return c;
        }
        /// <summary>
        /// Prints a description of the character submitted by the user based on what it is
        /// </summary>
        private static void CheckChar()
        {
            char input = AskForChar();

            Console.WriteLine();

            if (char.IsWhiteSpace(input))
            {
                Console.WriteLine("\nAnnoit tyhjän merkin.");
            }
            else if (char.IsDigit(input))
            {
                Console.WriteLine("\nAnnoit numeron {0}.", input);
            }
            else if (char.IsUpper(input))
            {
                Console.WriteLine("\nSyöttämäsi merkki on iso kirjain.");
            }
            else if (char.IsLower(input))
            {
                Console.WriteLine("\nSyöttämäsi merkki on pieni kirjain.");
            }
            else if (char.IsSymbol(input))
            {
                Console.WriteLine("\nSyöttämäsi merki on erikoismerkki.");
            }
            else
            {
                Console.WriteLine("\nOnnistuit syöttämään jotain ihan hassua!");
            }
        }
        static void Main(string[] args)
        {
            CheckChar();
        }
    }
}