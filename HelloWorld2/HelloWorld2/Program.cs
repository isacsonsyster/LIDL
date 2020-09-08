using System;

namespace HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new string[5];

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = Console.ReadLine();
            }
            for (int i = words.Length - 1; i >= 0;  i--)
            {
                
                    Console.WriteLine(words[i]);
               
            }
        }
    }
}
