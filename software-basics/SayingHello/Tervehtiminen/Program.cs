using System;

namespace SayingHello
{
    class Program
    {
        private string name;
        private int age;
        static void Main(string[] args)
        {
            Program John = new Program();
            
            Console.Write("Hi! What's your name? ");
            John.name = Console.ReadLine();
            Console.Write("Thanks " + John.name + "! " + "How old are you? ");
            John.age = int.Parse(Console.ReadLine());
            Console.Write("Nice to meet you " + John.name + ", " + John.age + "!");
        }
    }
}
