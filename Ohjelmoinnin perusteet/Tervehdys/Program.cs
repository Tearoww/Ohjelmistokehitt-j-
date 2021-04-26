using System;

namespace funktiot
{
    class Program
    {
        private static void Tervehdys(string firstName, string lastName, ref byte age)
        {
            Console.Write("\nAnna vielä ikäsi: ");

            age = byte.Parse(Console.ReadLine());

            Console.WriteLine("\nTervetuloa ohjelmaan {0} {1}!", firstName, lastName);
        }
        static void Main(string[] args)
        {
            string firstName, lastName;
            byte age = 1;

            Console.Write("Hei! Anna etunimesi: ");

            firstName = Console.ReadLine();

            Console.Write("\nKiitos {0}, antaisitko vielä sukunimesi: ", firstName);

            lastName = Console.ReadLine();

            Tervehdys(firstName, lastName, ref age);
        }
    }
}