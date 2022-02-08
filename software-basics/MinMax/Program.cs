using System;

namespace MinMax
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

            Console.Write("Hello! Give me a number: ");

            bool isNumber = int.TryParse(Console.ReadLine(), out num1);

            while (!isNumber)
            {
                Console.Write("\nGive a NUMBER: ");

                isNumber = int.TryParse(Console.ReadLine(), out num1);
            }

            Console.Write("\nGive a second number: ");

            isNumber = int.TryParse(Console.ReadLine(), out num2);

            while (!isNumber)
            {
                Console.Write("\nGive a NUMBER: ");

                isNumber = int.TryParse(Console.ReadLine(), out num2);
            }

            Console.Write("\nGive a third number: ");

            isNumber = int.TryParse(Console.ReadLine(), out num3);

            while (!isNumber)
            {
                Console.Write("\nGive a NUMBER: ");

                isNumber = int.TryParse(Console.ReadLine(), out num3);
            }

            minNum = Min(num1, num2, num3);
            maxNum = Max(num1, num2, num3);

            Console.WriteLine("\nThanks! The smallest number is {0} and the largest is {1}.", minNum, maxNum);
        }
    }
}
