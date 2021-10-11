using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart_Without_SRP
{
    public class ShoppingCart
    {
        // Notes:
        // small chnage in this class will make us test all the other functions as well
        // Double the effort
        // More chnaces of error
        // Low cohesion
        List<Product> products = new List<Product>();
        public List<Product> AddProduct()
        {
            Product product = new Product();
            product.Name = "Mobile";
            product.Price = 1000;
            products.Add(product);
            return products;
        }


        public double CalculateDiscount(Product product)
        {
            if(product.Name=="Mobile")
            {
                return (product.Price * 10) / 100;
            }
            else
            {
                return 0;
            }
        }
        public double Checkout(List<Product> products)
        {
            double finalCost=0;
            foreach(Product product in products)
            {
                double discountedPrice = CalculateDiscount(product);
                finalCost = finalCost + (product.Price - discountedPrice);
            }
            return finalCost;
        }
    }
}
