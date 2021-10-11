using System.Collections.Generic;

namespace ShoppingCart_With_SRP
{
    public class CartCheckout
    {
        DiscountMaster discountMaster = new DiscountMaster();
        public double Checkout(List<Product> products)
        {
            double finalCost = 0;
            foreach (Product product in products)
            {
                double discountedPrice = discountMaster.CalculateDiscount(product);
                finalCost = finalCost + (product.Price - discountedPrice);
            }
            return finalCost;
        }

        //methods deals with vouchers

    }
}
