using System;

namespace TextHandling
{
    class Program
    {
        private static int counter = 0;
        /// <summary>
        /// Asks the user for some text
        /// </summary>
        /// <returns>User's input as a string</returns>
        private static string AskForText()
        {
            string input;

            if (counter == 0)
            {
                Console.Write("Hei! Kirjoita minulle jotain tekstiä (\"exit\" poistuaksesi): ");
            }
            else
            {
                Console.Write("\n\nKirjoita minulle jotain tekstiä (\"exit\" poistuaksesi): ");
            }

            input = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Write("\nEt kirjoittanut mitään! Kirjoita jotain: ");

                input = Console.ReadLine();
            }

            counter++;

            return input;
        }
        /// <summary>
        /// Adds spaces between every character in a string
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Modified text as a string</returns>
        private static string AddSpaces(string text)
        {
            string spacedText = "";

            for (int i = 0; i < text.Length; i++)
            {
                spacedText = string.Join<char>(" ", text);
            }

            return spacedText;
        }
        /// <summary>
        /// Reverses the order of characters in a string
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Reversed text as a string</returns>
        private static string Reverse(string text)
        {
            char[] reversedText = text.ToCharArray();

            for (int i = 0, j = text.Length - 1; i < j; i++, j--)
            {
                reversedText[i] = text[j];
                reversedText[j] = text[i];
            }

            return new string(reversedText);
        }
        /// <summary>
        /// Finds the first letter 'a' from a string
        /// </summary>
        /// <param name="text"></param>
        /// <returns>The location of the first letter 'a' as an integer</returns>
        private static int FindLetterA(string text)
        {
            int locationOfA = text.IndexOf('a') + 1;

            return locationOfA;
        }
        /// <summary>
        /// Prints the user's text back with and without modifications
        /// </summary>
        private static void Print()
        {
            bool exit = false;

            while (!exit)
            {
                string text = AskForText().Replace(" ", Environment.NewLine);
                string spacedText = AddSpaces(text);
                string reversedText = Reverse(spacedText);

                if (text.Contains("exit", StringComparison.CurrentCultureIgnoreCase))
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("\n\nKirjoitit \n{0}.", text);

                    Console.WriteLine("\nVälien kanssa se on \n {0}.", spacedText);

                    Console.WriteLine("\nVälien kanssa ja käännettynä se on \n {0}", reversedText);

                    if (text.Contains('a'))
                    {
                        Console.WriteLine("\nEnsimmäinen tekstisi a-kirjain löytyi kohdasta {0}.", FindLetterA(text));
                    }
                    else
                    {
                        Console.WriteLine("\nKirjoittamassasi tekstissä ei ollut pientä a-kirjainta.");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Print();
        }
    }
}