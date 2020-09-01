using System;
using System.ComponentModel;

namespace HelloWorld
{
    class Program
    {
        static string Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Hello" + name + "How old are you?");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age:" + age);
           
            
        }
    }
}
