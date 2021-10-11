using ShoppingCart_With_SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart_With_SRP
{
    public class CartManagement
    {        
        public List<Product> AddProductIntoCart()
        {
            List<Product> products = new List<Product>();
            
            Product product = new Product();
            product.Name = "Laptop";
            product.Price = 1000;
            products.Add(product);

            product = new Product();
            product.Name = "Tablet";
            product.Price = 2000;
            products.Add(product);
            
            product = new Product();
            product.Name = "Mobile";
            product.Price = 2000;
            products.Add(product);
            
            return products;
        }
        public List<Product> DeleteProductFromCart(List<Product> finalProducts)
        {
            var itemToRemove = finalProducts.SingleOrDefault(product => product.Name == "Laptop");
            if (itemToRemove != null)
                finalProducts.Remove(itemToRemove);
            return finalProducts;
        }
    }
}
