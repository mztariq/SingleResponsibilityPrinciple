using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart_With_SRP
{
    public class DiscountMaster
    {
        public double CalculateDiscount(Product product)
        {
            if (product.Name == "Mobile")
            {
                return (product.Price * 10) / 100;
            }
            else
            {
                return 0;
            }
        }
    }
}
