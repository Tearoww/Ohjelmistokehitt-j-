using System;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            string sunny;
            string rainy;
            string temperature;
            
            Console.Write("Hello! Is the sun shining? (Y/N): ");

            sunny = Console.ReadLine();

            Console.Write("Is it raining? (Y/N): ");

            rainy = Console.ReadLine();

            Console.Write("Is the temperature above 0 Celsius? (Y/N): ");

            temperature = Console.ReadLine();

            if (sunny.Equals("Y", StringComparison.CurrentCultureIgnoreCase) && rainy.Equals("Y", StringComparison.CurrentCultureIgnoreCase) && temperature.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("The sun is shining and it's raining, summer must be coming.");
            }
            else if (sunny.Equals("N", StringComparison.CurrentCultureIgnoreCase) && rainy.Equals("Y", StringComparison.CurrentCultureIgnoreCase) && temperature.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Fall is here, the wind took the leaves with it.");
            }
            else if (sunny.Equals("N", StringComparison.CurrentCultureIgnoreCase) && rainy.Equals("N", StringComparison.CurrentCultureIgnoreCase) && temperature.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Sweet summertime!");
            }
            else if (sunny.Equals("Y", StringComparison.CurrentCultureIgnoreCase) && rainy.Equals("N", StringComparison.CurrentCultureIgnoreCase) && temperature.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Sweet summertime!");
            }
            else if (sunny.Equals("Y", StringComparison.CurrentCultureIgnoreCase) && rainy.Equals("Y", StringComparison.CurrentCultureIgnoreCase) && temperature.Equals("N", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Filled with show is the fresh winter weather");
            }
            else if (sunny.Equals("N", StringComparison.CurrentCultureIgnoreCase) && rainy.Equals("N", StringComparison.CurrentCultureIgnoreCase) && temperature.Equals("N", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("The snow made an angel in the hallway");
            }
            else if (sunny.Equals("Y", StringComparison.CurrentCultureIgnoreCase) && rainy.Equals("N", StringComparison.CurrentCultureIgnoreCase) && temperature.Equals("N", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("A snowball is what I'll make");
            }
        }
    }
}
