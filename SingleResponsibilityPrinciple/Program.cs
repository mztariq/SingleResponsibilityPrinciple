using ShoppingCart_With_SRP;
using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            CartManagement cartManagement = new CartManagement();
            CartCheckout cartCheckout = new CartCheckout();
            List<Product> initialproducts = new List<Product>();
            List<Product> confirmedProducts = new List<Product>();
            initialproducts = cartManagement.AddProductIntoCart();
            confirmedProducts = cartManagement.DeleteProductFromCart(initialproducts);
            double finalCartTotal = cartCheckout.Checkout(confirmedProducts);
            Console.WriteLine(finalCartTotal);
        }
    }
}
