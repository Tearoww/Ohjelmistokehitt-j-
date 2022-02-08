using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            bool exit = false;
            string input;
            byte x;
            string order;
            
            Console.Write("Hello! Give a student's name: ");

            input = Console.ReadLine();

            students.Add(input);

            Console.WriteLine();

            while (!exit)
            {
                Console.Write("Write \"Stop\", if you want to stop or give another student's name: ");

                input = Console.ReadLine();
                
                if (input.Contains("Stop", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.Write("\nThanks! How many students would you like to see?: ");

                    try
                    {
                        x = byte.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occurred.");
                        return;
                    }

                    while (x > students.Count)
                    {
                        Console.Write("\nThere aren't that many students in the class! Give a new amount: ");

                        try
                        {
                            x = byte.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("An error occurred.");
                            return;
                        }
                    }

                    Console.Write("\nDo you want to see the students in (a)scending or (d)escending alphabetical order?: ");

                    order = Console.ReadLine();

                    if (order.Contains("A", StringComparison.CurrentCultureIgnoreCase))
                    {
                        students.Sort();
                    }
                    else if (order.Contains("D", StringComparison.CurrentCultureIgnoreCase))
                    {
                        students.Sort();
                        students.Reverse();
                    }

                    Console.WriteLine("\nThe first {0} students in the class are:", x);

                    for (int i = 0; i < x; i++)
                    {
                        Console.WriteLine(students[i]);
                    }

                    exit = true;
                }
                else
                {
                    students.Add(input);
                }
            }
        }
    }
}
