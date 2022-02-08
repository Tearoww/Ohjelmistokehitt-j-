using System;

namespace Greeting
{
    class Program
    {
        private static void Greet(string firstName, string lastName, ref byte age)
        {
            Console.Write("\nFinally, your age: ");

            age = byte.Parse(Console.ReadLine());

            Console.WriteLine("\nWelcome {0} {1}!", firstName, lastName);
        }
        static void Main(string[] args)
        {
            string firstName, lastName;
            byte age = 1;

            Console.Write("Hi! What's your first name? ");

            firstName = Console.ReadLine();

            Console.Write("\nThanks you, {0}. And your last name? ", firstName);

            lastName = Console.ReadLine();

            Greet(firstName, lastName, ref age);
        }
    }
}
