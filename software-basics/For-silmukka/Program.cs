using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            
            Console.Write("Hello! Give me an integer: ");

            try
            {
                x = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred.");
                return;
            }
            
            for (int i = x; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
