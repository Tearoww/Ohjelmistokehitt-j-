using System;

namespace AgeCalc
{
    class Program
    {
        static void Male()
        {
            byte age;

            Console.Write("Please give your age: ");

            try
            {
                age = byte.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred.");
                return;
            }

            if (age <= 13)
            {
                Console.WriteLine("What's up, boy?");
            }
            else if (age > 13 && age < 26)
            {
                Console.WriteLine("How do you do, young man?");
            }
            else if (age > 25 && age < 57)
            {
                Console.WriteLine("You're a man in his best age!");
            }
            else
            {
                Console.WriteLine("You've reached an honorable age.");
            }
        }
        static void Female()
        {
            byte Age;

            Console.Write("Please give your age: ");

            try
            {
                Age = byte.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred.");
                return;
            }

            if (Age <= 13)
            {
                Console.WriteLine("What's up, girl?");
            }
            else if (Age > 13 && Age < 26)
            {
                Console.WriteLine("How do you do, young lady?");
            }
            else if (Age > 25 && Age < 57)
            {
                Console.WriteLine("You're a woman in her best age!");
            }
            else
            {
                Console.WriteLine("You've reached an honorable age.");
            }
        }
        static void Main(string[] args)
        {
            string Gender;

            Console.Write("Hello! Are you a man or a woman? ");

            try
            {
                Gender = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred.");
                return;
            }

            if (Gender == "man" || Gender == "Man")
            {
                Male();
            }
            else if (Gender == "woman" || Gender == "Woman")
            {
                Female();
            }
            else
            {
                Console.WriteLine("An error occurred.");
                return;
            }
        }
    }
}
