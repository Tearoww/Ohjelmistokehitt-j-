using System;

namespace HeightConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            short height;

            Console.Write("Hi! How tall are you? (cm): ");

            CheckInput: // Bad practise, might have been an example in school.
            try
            {
                height = short.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred.");
                return;
            }
            if (height <= 272 && height >= 54)
            {
                float meters = (float)Math.Round(height / 100f, 2, MidpointRounding.AwayFromZero);
                decimal miles = Math.Round(height / 160934m, 2, MidpointRounding.AwayFromZero);
                float yards = (float)Math.Round(height / 91.44f, 2, MidpointRounding.AwayFromZero);
                float inches = (float)Math.Round(height / 2.54f, 2, MidpointRounding.AwayFromZero);
                Console.WriteLine("You are {0} meters, {1} miles, {2} yards and {3} inches tall.", meters, miles, yards, inches);
            }
            else
            {
                Console.WriteLine("I don't believe you!");
                Console.Write("How tall are you REALLY? (cm): ");
                goto CheckInput;
            }
        }
    }
}
