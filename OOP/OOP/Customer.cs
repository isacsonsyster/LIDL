using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Customer
    {
        public List<Product> _cart = new List<Product>();

        public void Shopping()
        {
            Console.WriteLine("(1) Pink \n (2) Yellow \n (3) Purple \n (4) Cart List \n (5) Quit Shopping");
        }

    }
}
