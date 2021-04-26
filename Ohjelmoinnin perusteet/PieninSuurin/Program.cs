using System;

namespace funktiot
{
    class Program
    {
        private static int Min(int first, int second, int third)
        {
            return Math.Min(first, Math.Min(second, third));
        }
        private static int Max(int first, int second, int third)
        {
            return Math.Max(first, Math.Max(second, third));
        }
        static void Main(string[] args)
        {
            int num1, num2, num3, minNum, maxNum;

            Console.Write("Hei! Anna ensimmäinen numero: ");

            bool isNumber = int.TryParse(Console.ReadLine(), out num1);

            while (!isNumber)
            {
                Console.Write("\nAnna NUMERO: ");

                isNumber = int.TryParse(Console.ReadLine(), out num1);
            }

            Console.Write("\nAnna toinen numero: ");

            isNumber = int.TryParse(Console.ReadLine(), out num2);

            while (!isNumber)
            {
                Console.Write("\nAnna NUMERO: ");

                isNumber = int.TryParse(Console.ReadLine(), out num2);
            }

            Console.Write("\nAnna kolmas numero: ");

            isNumber = int.TryParse(Console.ReadLine(), out num3);

            while (!isNumber)
            {
                Console.Write("\nAnna NUMERO: ");

                isNumber = int.TryParse(Console.ReadLine(), out num3);
            }

            minNum = Min(num1, num2, num3);
            maxNum = Max(num1, num2, num3);

            Console.WriteLine("\nKiitos! pienin numero on {0} ja suurin {1}.", minNum, maxNum);
        }
    }
}