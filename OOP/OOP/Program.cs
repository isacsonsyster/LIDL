using System;
using System.ComponentModel;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer Ester = new Customer();

            bool shop = true;
            while (shop)
            {
                Ester.Shopping();
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Product pink = new Product();
                        pink._productName = "pink";
                        Ester._cart.Add(pink);
                        break;
                    case 2:
                        Product yellow = new Product();
                        yellow._productName = "yellow";
                        Ester._cart.Add(yellow);
                        break;
                    case 3:
                        Product purple = new Product();
                        purple._productName = "purple";
                        Ester._cart.Add(purple);
                        break;
                    case 4:
                        foreach(Product item in Ester._cart)
                        {
                            Console.WriteLine(item._productName);
                        }
                        break;
                    case 5:
                        shop = false;
                        break;
                }
            }
        }
    }
}
