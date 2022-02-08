using System;

namespace Heroes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] heroes = new string[4, 5] {
                { "HERO", "Ana", "Bastion", "Brigitte", "D.Va (Mech)"},
                { "ROLE", "Support", "Defense", "Support", "Tank"},
                { "HEALTH", "200", "200", "200", "400"},
                { "ARMOR", "0", "100", "50", "200"}
                };

            string selectedHero;
            int x = 0;
            
            Console.WriteLine("Heroes:");

            for (int i = 1; i <= heroes.GetLength(0); i++)
            {
                Console.WriteLine("\n {0}", heroes[0, i]);
            }

            Console.Write("\nWhich heros stats would you like to see?: ");

            selectedHero = Console.ReadLine();

            if (selectedHero.Contains("Ana", StringComparison.CurrentCultureIgnoreCase))
            {
                x = 1;
            }
            else if (selectedHero.Contains("Bastion", StringComparison.CurrentCultureIgnoreCase))
            {
                x = 2;
            }
            else if (selectedHero.Contains("Brigitte", StringComparison.CurrentCultureIgnoreCase))
            {
                x = 3;
            }
            else if (selectedHero.Contains("D", StringComparison.CurrentCultureIgnoreCase))
            {
                x = 4;
            }

            for (int j = 1; j < 4; j++)
            {
                Console.WriteLine("\n {0}: {1}", heroes[j, 0], heroes[j, x]);
            }
        }
    }
}
