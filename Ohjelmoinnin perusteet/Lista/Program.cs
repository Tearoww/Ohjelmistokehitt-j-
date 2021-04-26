using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Students = new List<string>();
            bool Exit = false;
            string Input;
            byte x;
            string Order;
            
            Console.Write("Hei! Anna luokan oppilaan nimi: ");

            Input = Console.ReadLine();

            Students.Add(Input);

            Console.WriteLine();

            while (!Exit)
            {
                Console.Write("Kirjoita \"Lopeta\", jos haluat lopettaa tai anna seuraavan oppilaan nimi: ");

                Input = Console.ReadLine();
                
                if (Input.Contains("Lopeta", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.Write("\nKiitos! Montako luokan oppilasta haluat nähdä?: ");

                    try
                    {
                        x = byte.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Tapahtui virhe.");
                        return;
                    }

                    while (x > Students.Count)
                    {
                        Console.Write("\nLuokassa ei ole noin montaa oppilasta! Anna uusi määrä: ");

                        try
                        {
                            x = byte.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Tapahtui virhe.");
                            return;
                        }
                    }

                    Console.Write("\nHaluatko nähdä oppilaat (n)ousevassa vai (l)askevassa aakkosjärjestyksessä?: ");

                    Order = Console.ReadLine();

                    if (Order.Contains("N", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Students.Sort();
                    }
                    else if (Order.Contains("L", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Students.Sort();
                        Students.Reverse();
                    }

                    Console.WriteLine("\nLuokan {0} ensimmäistä oppilasta ovat:", x);

                    for (int i = 0; i < x; i++)
                    {
                        Console.WriteLine(Students[i]);
                    }

                    Exit = true;
                }
                else
                {
                    Students.Add(Input);
                }
            }
        }
    }
}