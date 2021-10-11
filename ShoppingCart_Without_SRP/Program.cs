using System;
using System.Collections.Generic;

namespace ShoppingCart_Without_SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            List<Product> products = new List<Product>();
            products = shoppingCart.AddProduct();
            double finalCartTotal = shoppingCart.Checkout(products);
            Console.WriteLine(finalCartTotal);
        }
    }
}
