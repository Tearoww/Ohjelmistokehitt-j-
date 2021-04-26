using System;

namespace For_silmukka
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            
            Console.Write("Hei! Anna jokin luku: ");

            try
            {
                x = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Tapahtui virhe.");
                return;
            }
            
            for (int i = x; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}