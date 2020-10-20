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
                        Product adidas = new Product();
                        adidas._productName = "adidas";
                        Ester._cart.Add(adidas);
                        break;
                    case 2:
                        Product yellow = new Product();
                        yellow._productName = "yellow";
                        Ester._cart.Add(yellow);
                        break;
                    case 3:
                        Product apple = new Product();
                        apple._productName = "apple";
                        Ester._cart.Add(apple);
                        break;
                    case 4:
                        foreach(Product item in Ester._cart)
                        {
                            //skriver ut alla 
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
