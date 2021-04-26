using System;

namespace Tervehtiminen
{
    class Program
    {
        private string Name;
        private int Age;
        static void Main(string[] args)
        {
            Program Kalle = new Program();
            
            Console.Write("Hei! Anna nimesi: ");
            Kalle.Name = Console.ReadLine();
            Console.Write("Kiitos " + Kalle.Name + "! " + "Antaisitko vielä ikäsi: ");
            Kalle.Age = int.Parse(Console.ReadLine());
            Console.Write("Moi " + Kalle.Name + " " + Kalle.Age + "v!");
        }
    }
}
