using System;

namespace HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " how old are you?");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Are you alive? (yes or no)");
            var alive = Console.ReadLine();

            bool dead = false; 
            if (alive == "yes")
            {
                dead = true;
                Console.WriteLine("Good you are alive!!!!");
            }
            else
            {
                dead = false;
                Console.WriteLine("Sorry to hear that you are dead, when is your funeral?");
            }
        }
    }
}
