using System;

namespace Herot
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Heroes = new string[4, 5] {
                { "HERO", "Ana", "Bastion", "Brigitte", "D.Va (Mech)"},
                { "ROLE", "Support", "Defense", "Support", "Tank"},
                { "HEALTH", "200", "200", "200", "400"},
                { "ARMOR", "0", "100", "50", "200"}
                };

            string SelectedHero;
            int x = 0;
            
            Console.WriteLine("Herot:");

            for (int i = 1; i <= Heroes.GetLength(0); i++)
            {
                Console.WriteLine("\n {0}", Heroes[0, i]);
            }

            Console.Write("\nMinkä heron statsit haluat nähdä?: ");

            SelectedHero = Console.ReadLine();

            if (SelectedHero.Contains("Ana", StringComparison.CurrentCultureIgnoreCase))
            {
                x = 1;
            }
            else if (SelectedHero.Contains("Bastion", StringComparison.CurrentCultureIgnoreCase))
            {
                x = 2;
            }
            else if (SelectedHero.Contains("Brigitte", StringComparison.CurrentCultureIgnoreCase))
            {
                x = 3;
            }
            else if (SelectedHero.Contains("D", StringComparison.CurrentCultureIgnoreCase))
            {
                x = 4;
            }

            for (int j = 1; j < 4; j++)
            {
                Console.WriteLine("\n {0}: {1}", Heroes[j, 0], Heroes[j, x]);
            }
        }
    }
}