using ShoppingCart_With_SRP;
using System.Collections.Generic;
using Xunit;

namespace SRP.Tests.Unit
{
    public class CartCheckoutTests
    {
        [Theory]
        [InlineData(17)]
        [InlineData(100)]
        [InlineData(34)]
        public void When_Products_Are_Passed_Return_Total_Price(int price)
        {
            //Arrange
            var _sut = new CartCheckout();
            var products = new List<Product>();
            products.Add(new Product { Name = $"Test", Price = price });

            //Act
            var result = _sut.Checkout(products);

            //Assert
            Assert.Equal(price, result);

        }

        [Fact]
        public void When_No_Are_Passed_Return_Zero()
        {
            //Arrange
            var _sut = new CartCheckout();
            var products = new List<Product>();

            //Act
            var result = _sut.Checkout(products);

            //Assert
            Assert.Equal(0, result);
        }


    }
}
