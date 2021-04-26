using System;

namespace Loogiset_operaattorit
{
    class Program
    {
        static void Main(string[] args)
        {
            string Sunny;
            string Rainy;
            string Temperature;
            
            Console.Write("Hei! Paistaako aurinko? (K/E): ");

            Sunny = Console.ReadLine();

            Console.Write("Entä sataako vettä? (K/E): ");

            Rainy = Console.ReadLine();

            Console.Write("Onko lämpötila > 0? (K/E): ");

            Temperature = Console.ReadLine();

            if (Sunny.Equals("K", StringComparison.CurrentCultureIgnoreCase) && Rainy.Equals("K", StringComparison.CurrentCultureIgnoreCase) && Temperature.Equals("K", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Aurinko paistaa ja vettä sataa, taitaa tulla kesä.");
            }
            else if (Sunny.Equals("E", StringComparison.CurrentCultureIgnoreCase) && Rainy.Equals("K", StringComparison.CurrentCultureIgnoreCase) && Temperature.Equals("K", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Syksy saapui, lehdet vei tuuli mennessään.");
            }
            else if (Sunny.Equals("E", StringComparison.CurrentCultureIgnoreCase) && Rainy.Equals("E", StringComparison.CurrentCultureIgnoreCase) && Temperature.Equals("K", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Jo joutui armas aika ja suvi suloinen.");
            }
            else if (Sunny.Equals("K", StringComparison.CurrentCultureIgnoreCase) && Rainy.Equals("E", StringComparison.CurrentCultureIgnoreCase) && Temperature.Equals("K", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Jo joutui armas aika ja suvi suloinen.");
            }
            else if (Sunny.Equals("K", StringComparison.CurrentCultureIgnoreCase) && Rainy.Equals("K", StringComparison.CurrentCultureIgnoreCase) && Temperature.Equals("E", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Lunta tulvillaan on raikas talvisää");
            }
            else if (Sunny.Equals("E", StringComparison.CurrentCultureIgnoreCase) && Rainy.Equals("E", StringComparison.CurrentCultureIgnoreCase) && Temperature.Equals("E", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Lumi teki enkelin eteiseen");
            }
            else if (Sunny.Equals("K", StringComparison.CurrentCultureIgnoreCase) && Rainy.Equals("E", StringComparison.CurrentCultureIgnoreCase) && Temperature.Equals("E", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Pyöritän, pyöritän, lumipallon pyöritän");
            }
        }
    }
}