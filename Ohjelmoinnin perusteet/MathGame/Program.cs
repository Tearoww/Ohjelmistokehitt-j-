using System;

namespace MathGame
{
    class Program
    {
        private enum Menu { Exit, Sum, Subtraction, Multiplication, Division }
        private static int counter = 0, awards = 0;

        /// <summary>
        /// Parses user input into boolean
        /// </summary>
        /// <returns>A Valid boolean</returns>
        private static bool ParseBoolean()
        {
            string input;
            do
            {
                input = Console.ReadLine().ToLower();
                if (input.Equals("k") || input.Equals("e"))
                    break;
                else
                    Console.WriteLine("\nEt vastannut kysymykseen! Kirjoita \"K\" tai \"E\"?\n> ");
            }while(true);
            bool answer = false;
            if (input == "k")
                answer = true;
            return answer;
        }
        /// <summary>
        /// Asks the user which math operation they would like to exercise with or without negatives and/or decimals
        /// </summary>
        private static void MainMenu()
        {
            bool isNumber = false, isAnswer = false, negativesAllowed = false, integersOnly = false;
            sbyte operation = 127;
            
            if (counter == 0)
            {
                Console.WriteLine("Hei! Mitä laskutoimitusta haluat harjoitella?");
            }
            else
            {
                if (counter != 0 && counter % 5 == 0)
                {
                    Console.WriteLine("\nOikeita vastauksia tähän mennessä {0}/{1}.\n", awards, counter);
                }

                Console.WriteLine("\nMitä laskutoimitusta haluat harjoitella?");
            }

            Console.WriteLine("0. Poistu ohjelmasta");
            Console.WriteLine("1. Yhteenlasku");
            Console.WriteLine("2. Vähennyslasku");
            Console.WriteLine("3. Kertolasku");
            Console.WriteLine("4. Jakolasku");
            Console.Write("> ");

            while (!isNumber)
            {
                try
                {
                    operation = sbyte.Parse(Console.ReadLine());

                    if (operation >= 0 && operation <= 4)
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

            switch ((Menu)operation)
            {
                case Menu.Exit:
                    Console.WriteLine("\nKiitos ohjelman käytöstä!");
                    return;
            }

            Console.Write("\nHaluatko harjoitella vain positiivisilla luvuilla? (K)yllä/(E)n?\n> ");

            isAnswer = ParseBoolean();
            if(!isAnswer)
                negativesAllowed = true;
            

            Console.Write("\nHaluatko harjoitella vain tasaluvuilla? (K)yllä/(E)n?\n> ");

            isAnswer = ParseBoolean();
            if(isAnswer)
                integersOnly = true;


            counter++;

            switch ((Menu)operation)
            {
                case Menu.Sum:
                    Addition(negativesAllowed, integersOnly);
                    break;
                case Menu.Subtraction:
                    Subtraction(negativesAllowed, integersOnly);
                    break;
                case Menu.Multiplication:
                    Multiplication(negativesAllowed, integersOnly);
                    break;
                case Menu.Division:
                    Division(negativesAllowed, integersOnly);
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Performs an addition operation based on the user's conditions and compares the user's answer to the correct one
        /// </summary>
        /// <param name="negativesAllowed"></param>
        /// <param name="integersOnly"></param>
        private static void Addition(bool negativesAllowed, bool integersOnly)
        {
            if (negativesAllowed)
            {
                if (integersOnly)
                {
                    //Numbers can be negative but integers only

                    Random pool = new Random();
                    sbyte x = (sbyte)pool.Next(sbyte.MinValue, sbyte.MaxValue);
                    sbyte y = (sbyte)pool.Next(sbyte.MinValue, sbyte.MaxValue);
                    short sum = (short)(x + y);
                    short answer;
                    bool isNumber = false;
                    string parenthesis1 = "", parenthesis2 = "";

                    if (y < 0)
                    {
                        parenthesis1 = "(";
                        parenthesis2 = ")";
                    }

                    Console.WriteLine("\nPaljonko on {0} + {1}{2}{3}?", x, parenthesis1, y, parenthesis2);
                    Console.Write("> ");

                    while (!isNumber)
                    {
                        try
                        {
                            answer = short.Parse(Console.ReadLine());

                            isNumber = true;

                            if (answer == sum)
                            {
                                Console.WriteLine("\nOikein!\n");

                                awards++;

                                MainMenu();
                            }
                            else
                            {
                                Console.WriteLine("\nVäärin! Oikea vastaus on {0}.\n", sum);

                                MainMenu();
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nAnna NUMERO!");
                            Console.Write("> ");
                        }
                    }
                }
                else
                {
                    //Numbers can be negative and aren't restricted to integers only

                    Random pool = new Random();
                    double x = Math.Round(pool.Next(sbyte.MinValue, sbyte.MaxValue) + pool.NextDouble(), 2);
                    double y = Math.Round(pool.Next(sbyte.MinValue, sbyte.MaxValue) + pool.NextDouble(), 2);
                    double sum = Math.Round(x + y, 2);
                    double answer;
                    bool isNumber = false;
                    string parenthesis1 = "", parenthesis2 = "";

                    if (y < 0)
                    {
                        parenthesis1 = "(";
                        parenthesis2 = ")";
                    }

                    Console.WriteLine("\nPaljonko on {0} + {1}{2}{3} (kahden desimaalin tarkkuudella)?", x, parenthesis1, y, parenthesis2);
                    Console.Write("> ");

                    while (!isNumber)
                    {
                        try
                        {
                            answer = double.Parse(Console.ReadLine());

                            isNumber = true;

                            if (answer == sum)
                            {
                                Console.WriteLine("\nOikein!\n");

                                awards++;

                                MainMenu();
                            }
                            else
                            {
                                Console.WriteLine("\nVäärin! Oikea vastaus on {0}.\n", sum);

                                MainMenu();
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nAnna NUMERO!");
                            Console.Write("> ");
                        }
                    }
                }
            }
            else
            {
                if (integersOnly)
                {
                    //Numbers can't be negative and are restricted to integers only

                    Random pool = new Random();
                    byte x = (byte)pool.Next(byte.MinValue, byte.MaxValue);
                    byte y = (byte)pool.Next(byte.MinValue, byte.MaxValue);
                    ushort sum = (ushort)(x + y);
                    ushort answer;
                    bool isNumber = false;

                    Console.WriteLine("\nPaljonko on {0} + {1}?", x, y);
                    Console.Write("> ");

                    while (!isNumber)
                    {
                        try
                        {
                            answer = ushort.Parse(Console.ReadLine());

                            isNumber = true;

                            if (answer == sum)
                            {
                                Console.WriteLine("\nOikein!\n");

                                awards++;

                                MainMenu();
                            }
                            else
                            {
                                Console.WriteLine("\nVäärin! Oikea vastaus on {0}.\n", sum);

                                MainMenu();
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nAnna NUMERO!");
                            Console.Write("> ");
                        }
                    }
                }
                else
                {
                    //Numbers can't be negative but aren't restricted to integers only

                    Random pool = new Random();
                    double x = Math.Round(pool.Next(byte.MinValue, byte.MaxValue) + pool.NextDouble(), 2);
                    double y = Math.Round(pool.Next(byte.MinValue, byte.MaxValue) + pool.NextDouble(), 2);
                    double sum = Math.Round(x + y, 2);
                    double answer;
                    bool isNumber = false;

                    Console.WriteLine("\nPaljonko on {0} + {1} (kahden desimaalin tarkkuudella)?", x, y);
                    Console.Write("> ");

                    while (!isNumber)
                    {
                        try
                        {
                            answer = double.Parse(Console.ReadLine());

                            isNumber = true;

                            if (answer == sum)
                            {
                                Console.WriteLine("\nOikein!\n");

                                awards++;

                                MainMenu();
                            }
                            else
                            {
                                Console.WriteLine("\nVäärin! Oikea vastaus on {0}.\n", sum);

                                MainMenu();
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nAnna NUMERO!");
                            Console.Write("> ");
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Performs a subtraction operation based on the user's conditions and compares the user's answer to the correct one
        /// </summary>
        /// <param name="negativesAllowed"></param>
        /// <param name="integersOnly"></param>
        private static void Subtraction(bool negativesAllowed, bool integersOnly)
        {
            if (negativesAllowed)
            {
                if (integersOnly)
                {
                    //Numbers can be negative but integers only

                    Random pool = new Random();
                    sbyte x = (sbyte)pool.Next(sbyte.MinValue, sbyte.MaxValue);
                    sbyte y = (sbyte)pool.Next(sbyte.MinValue, sbyte.MaxValue);
                    short difference = (short)Math.Round((double)x - (double)y, 2);
                    short answer;
                    bool isNumber = false;
                    string parenthesis1 = "", parenthesis2 = "";

                    if (y < 0)
                    {
                        parenthesis1 = "(";
                        parenthesis2 = ")";
                    }

                    Console.WriteLine("\nPaljonko on {0} - {1}{2}{3}?", x, parenthesis1, y, parenthesis2);
                    Console.Write("> ");

                    while (!isNumber)
                    {
                        try
                        {
                            answer = short.Parse(Console.ReadLine());

                            isNumber = true;

                            if (answer == difference)
                            {
                                Console.WriteLine("\nOikein!\n");

                                awards++;

                                MainMenu();
                            }
                            else
                            {
                                Console.WriteLine("\nVäärin! Oikea vastaus on {0}.\n", difference);

                                MainMenu();
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nAnna NUMERO!");
                            Console.Write("> ");
                        }
                    }
                }
                else
                {
                    //Numbers can be negative and aren't restricted to integers only

                    Random pool = new Random();
                    double x = Math.Round(pool.Next(sbyte.MinValue, sbyte.MaxValue) + pool.NextDouble(), 2);
                    double y = Math.Round(pool.Next(sbyte.MinValue, sbyte.MaxValue) + pool.NextDouble(), 2);
                    double difference = Math.Round(x - y, 2);
                    double answer;
                    bool isNumber = false;
                    string parenthesis1 = "", parenthesis2 = "";

                    if (y < 0)
                    {
                        parenthesis1 = "(";
                        parenthesis2 = ")";
                    }

                    Console.WriteLine("\nPaljonko on {0} - {1}{2}{3} (kahden desimaalin tarkkuudella)?", x, parenthesis1, y, parenthesis2);
                    Console.Write("> ");

                    while (!isNumber)
                    {
                        try
                        {
                            answer = double.Parse(Console.ReadLine());

                            isNumber = true;

                            if (answer == difference)
                            {
                                Console.WriteLine("\nOikein!\n");

                                awards++;

                                MainMenu();
                            }
                            else
                            {
                                Console.WriteLine("\nVäärin! Oikea vastaus on {0}.\n", difference);

                                MainMenu();
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nAnna NUMERO!");
                            Console.Write("> ");
                        }
                    }
                }
            }
            else
            {
                if (integersOnly)
                {
                    //Numbers can't be negative and are restricted to integers only

                    Random pool = new Random();
                    byte x = (byte)pool.Next(byte.MinValue, byte.MaxValue);
                    byte y = (byte)pool.Next(byte.MinValue, byte.MaxValue);
                    short difference = (short)(x - y);
                    short answer;
                    bool isNumber = false;

                    Console.WriteLine("\nPaljonko on {0} - {1}?", x, y);
                    Console.Write("> ");

                    while (!isNumber)
                    {
                        try
                        {
                            answer = short.Parse(Console.ReadLine());

                            isNumber = true;

                            if (answer == difference)
                            {
                                Console.WriteLine("\nOikein!\n");

                                awards++;

                                MainMenu();
                            }
                            else
                            {
                                Console.WriteLine("\nVäärin! Oikea vastaus on {0}.\n", difference);

                                MainMenu();
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nAnna NUMERO!");
                            Console.Write("> ");
                        }
                    }
                }
                else
                {
                    //Numbers can't be negative but aren't restricted to integers only

                    Random pool = new Random();
                    double x = Math.Round(pool.Next(byte.MinValue, byte.MaxValue) + pool.NextDouble(), 2);
                    double y = Math.Round(pool.Next(byte.MinValue, byte.MaxValue) + pool.NextDouble(), 2);
                    double difference = Math.Round(x - y, 2);
                    double answer;
                    bool isNumber = false;

                    Console.WriteLine("\nPaljonko on {0} - {1} (kahden desimaalin tarkkuudella)?", x, y);
                    Console.Write("> ");

                    while (!isNumber)
                    {
                        try
                        {
                            answer = double.Parse(Console.ReadLine());

                            isNumber = true;

                            if (answer == difference)
                            {
                                Console.WriteLine("\nOikein!\n");

                                awards++;

                                MainMenu();
                            }
                            else
                            {
                                Console.WriteLine("\nVäärin! Oikea vastaus on {0}.\n", difference);

                                MainMenu();
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nAnna NUMERO!");
                            Console.Write("> ");
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Performs a multiplication operation based on the user's conditions and compares the user's answer to the correct one
        /// </summary>
        /// <param name="negativesAllowed"></param>
        /// <param name="integersOnly"></param>
        private static void Multiplication(bool negativesAllowed, bool integersOnly)
        {
            if (negativesAllowed)
            {
                if (integersOnly)
                {
                    //Numbers can be negative but integers only

                    Random pool = new Random();
                    sbyte x = (sbyte)pool.Next(sbyte.MinValue, sbyte.MaxValue);
                    sbyte y = (sbyte)pool.Next(sbyte.MinValue, sbyte.MaxValue);
                    int product = x * y;
                    int answer;
                    bool isNumber = false;
                    string parenthesis1 = "", parenthesis2 = "";

                    if (y < 0)
                    {
                        parenthesis1 = "(";
                        parenthesis2 = ")";
                    }

                    Console.WriteLine("\nPaljonko on {0} * {1}{2}{3}?", x, parenthesis1, y, parenthesis2);
                    Console.Write("> ");

                    while (!isNumber)
                    {
                        try
                        {
                            answer = int.Parse(Console.ReadLine());

                            isNumber = true;

                            if (answer == product)
                            {
                                Console.WriteLine("\nOikein!\n");

                                awards++;

                                MainMenu();
                            }
                            else
                            {
                                Console.WriteLine("\nVäärin! Oikea vastaus on {0}.\n", product);

                                MainMenu();
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nAnna NUMERO!");
                            Console.Write("> ");
                        }
                    }
                }
                else
                {
                    //Numbers can be negative and aren't restricted to integers only

                    Random pool = new Random();
                    double x = Math.Round(pool.Next(sbyte.MinValue, sbyte.MaxValue) + pool.NextDouble(), 2);
                    double y = Math.Round(pool.Next(sbyte.MinValue, sbyte.MaxValue) + pool.NextDouble(), 2);
                    double product = Math.Round(x * y, 2);
                    double answer;
                    bool isNumber = false;
                    string parenthesis1 = "", parenthesis2 = "";

                    if (y < 0)
                    {
                        parenthesis1 = "(";
                        parenthesis2 = ")";
                    }

                    Console.WriteLine("\nPaljonko on {0} * {1}{2}{3} (kahden desimaalin tarkkuudella)?", x, parenthesis1, y, parenthesis2);
                    Console.Write("> ");

                    while (!isNumber)
                    {
                        try
                        {
                            answer = double.Parse(Console.ReadLine());

                            isNumber = true;

                            if (answer == product)
                            {
                                Console.WriteLine("\nOikein!\n");

                                awards++;

                                MainMenu();
                            }
                            else
                            {
                                Console.WriteLine("\nVäärin! Oikea vastaus on {0}.\n", product);

                                MainMenu();
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nAnna NUMERO!");
                            Console.Write("> ");
                        }
                    }
                }
            }
            else
            {
                if (integersOnly)
                {
                    //Numbers can't be negative and are restricted to integers only

                    Random pool = new Random();
                    byte x = (byte)pool.Next(byte.MinValue, byte.MaxValue);
                    byte y = (byte)pool.Next(byte.MinValue, byte.MaxValue);
                    ushort product = (ushort)(x * y);
                    ushort answer;
                    bool isNumber = false;

                    Console.WriteLine("\nPaljonko on {0} * {1}?", x, y);
                    Console.Write("> ");

                    while (!isNumber)
                    {
                        try
                        {
                            answer = ushort.Parse(Console.ReadLine());

                            isNumber = true;

                            if (answer == product)
                            {
                                Console.WriteLine("\nOikein!\n");

                                awards++;

                                MainMenu();
                            }
                            else
                            {
                                Console.WriteLine("\nVäärin! Oikea vastaus on {0}.\n", product);

                                MainMenu();
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nAnna NUMERO!");
                            Console.Write("> ");
                        }
                    }
                }
                else
                {
                    //Numbers can't be negative but aren't restricted to integers only

                    Random pool = new Random();
                    double x = Math.Round(pool.Next(byte.MinValue, byte.MaxValue) + pool.NextDouble(), 2);
                    double y = Math.Round(pool.Next(byte.MinValue, byte.MaxValue) + pool.NextDouble(), 2);
                    double product = Math.Round(x * y, 2);
                    double answer;
                    bool isNumber = false;

                    Console.WriteLine("\nPaljonko on {0} * {1} (kahden desimaalin tarkkuudella)?", x, y);
                    Console.Write("> ");

                    while (!isNumber)
                    {
                        try
                        {
                            answer = double.Parse(Console.ReadLine());

                            isNumber = true;

                            if (answer == product)
                            {
                                Console.WriteLine("\nOikein!\n");

                                awards++;

                                MainMenu();
                            }
                            else
                            {
                                Console.WriteLine("\nVäärin! Oikea vastaus on {0}.\n", product);

                                MainMenu();
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nAnna NUMERO!");
                            Console.Write("> ");
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Performs a division operation based on the user's conditions and compares the user's answer to the correct one
        /// </summary>
        /// <param name="negativesAllowed"></param>
        /// <param name="integersOnly"></param>
        private static void Division(bool negativesAllowed, bool integersOnly)
        {
            if (negativesAllowed)
            {
                if (integersOnly)
                {
                    //Numbers can be negative but integers only

                    Random pool = new Random();
                    byte x = (byte)pool.Next(byte.MinValue, byte.MaxValue);
                    byte y = (byte)pool.Next(1, byte.MaxValue);
                    double quotient = Math.Round((double)x / (double)y, 2);
                    double answer;
                    bool isNumber = false;
                    string parenthesis1 = "", parenthesis2 = "";

                    if (y < 0)
                    {
                        parenthesis1 = "(";
                        parenthesis2 = ")";
                    }

                    Console.WriteLine("\nPaljonko on {0} / {1}{2}{3} (kahden desimaalin tarkkuudella)?", x, parenthesis1, y, parenthesis2);
                    Console.Write("> ");

                    while (!isNumber)
                    {
                        try
                        {
                            answer = double.Parse(Console.ReadLine());

                            isNumber = true;

                            if (answer == quotient)
                            {
                                Console.WriteLine("\nOikein!\n");

                                awards++;

                                MainMenu();
                            }
                            else
                            {
                                Console.WriteLine("\nVäärin! Oikea vastaus on {0}.\n", quotient);

                                MainMenu();
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nAnna NUMERO!");
                            Console.Write("> ");
                        }
                    }
                }
                else
                {
                    //Numbers can be negative and aren't restricted to integers only

                    Random pool = new Random();
                    double x = Math.Round(pool.Next(sbyte.MinValue, sbyte.MaxValue) + pool.NextDouble(), 2);
                    double y = Math.Round(pool.Next(1, sbyte.MaxValue) + pool.NextDouble(), 2);
                    double quotient = Math.Round((double)x / (double)y, 2);
                    double answer;
                    bool isNumber = false;
                    string parenthesis1 = "", parenthesis2 = "";

                    if (y < 0)
                    {
                        parenthesis1 = "(";
                        parenthesis2 = ")";
                    }

                    Console.WriteLine("\nPaljonko on {0} / {1}{2}{3} (kahden desimaalin tarkkuudella)?", x, parenthesis1, y, parenthesis2);
                    Console.Write("> ");

                    while (!isNumber)
                    {
                        try
                        {
                            answer = double.Parse(Console.ReadLine());

                            isNumber = true;

                            if (answer == quotient)
                            {
                                Console.WriteLine("\nOikein!\n");

                                awards++;

                                MainMenu();
                            }
                            else
                            {
                                Console.WriteLine("\nVäärin! Oikea vastaus on {0}.\n", quotient);

                                MainMenu();
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nAnna NUMERO!");
                            Console.Write("> ");
                        }
                    }
                }
            }
            else
            {
                if (integersOnly)
                {
                    //Numbers can't be negative and are restricted to integers only

                    Random pool = new Random();
                    byte x = (byte)pool.Next(byte.MinValue, byte.MaxValue);
                    byte y = (byte)pool.Next(1, byte.MaxValue);
                    double quotient = Math.Round((double)x / (double)y, 2);
                    double answer;
                    bool isNumber = false;

                    Console.WriteLine("\nPaljonko on {0} / {1} (kahden desimaalin tarkkuudella)?", x, y);
                    Console.Write("> ");

                    while (!isNumber)
                    {
                        try
                        {
                            answer = double.Parse(Console.ReadLine());

                            isNumber = true;

                            if (answer == quotient)
                            {
                                Console.WriteLine("\nOikein!\n");

                                awards++;

                                MainMenu();
                            }
                            else
                            {
                                Console.WriteLine("\nVäärin! Oikea vastaus on {0}.\n", quotient);

                                MainMenu();
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nAnna NUMERO!");
                            Console.Write("> ");
                        }
                    }
                }
                else
                {
                    //Numbers can't be negative but aren't restricted to integers only

                    Random pool = new Random();
                    double x = Math.Round(pool.Next(byte.MinValue, byte.MaxValue) + pool.NextDouble(), 2);
                    double y = Math.Round(pool.Next(1, byte.MaxValue) + pool.NextDouble(), 2);
                    double quotient = Math.Round((double)x / (double)y, 2);
                    double answer;
                    bool isNumber = false;

                    Console.WriteLine("\nPaljonko on {0} / {1} (kahden desimaalin tarkkuudella)?", x, y);
                    Console.Write("> ");

                    while (!isNumber)
                    {
                        try
                        {
                            answer = double.Parse(Console.ReadLine());

                            isNumber = true;

                            if (answer == quotient)
                            {
                                Console.WriteLine("\nOikein!\n");

                                awards++;

                                MainMenu();
                            }
                            else
                            {
                                Console.WriteLine("\nVäärin! Oikea vastaus on {0}.\n", quotient);

                                MainMenu();
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nAnna NUMERO!");
                            Console.Write("> ");
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            MainMenu();
        }
    }
}