using ShoppingCart_Without_SRP;
using System.Collections.Generic;
using Xunit;

namespace SRP.Tests.Unit
{
    public class ShoppingCartTests
    {
        private ShoppingCart _sut;

        public ShoppingCartTests()
        {
            _sut = new ShoppingCart();
        }

        [Fact]
        public void When_Products_Are_added_We_Should_ALways_Get_Single_Product_Back()
        {
            //Act            
            var result = _sut.AddProduct();

            //Assert
            Assert.Single(result);
        }


        [Fact]
        public void When_Mobile_Product_Passed_Gets_result()
        {
            //Arrange
            var product = new Product { Name = "Mobile", Price = 12 };

            //Act
            var result = _sut.CalculateDiscount(product);

            //Assert
            Assert.Equal(1.2, result);
        }

        [Theory]
        [InlineData("Tablet")]
        [InlineData("Car")]
        [InlineData("Blabla")]
        public void When_Product_Is_Not_Mobile_Gets_Zero(string name)
        {
            //Arrange
            var product = new Product { Name = name, Price = 12 };

            //Act
            var result = _sut.CalculateDiscount(product);

            //Assert
            Assert.Equal(0, result);
        }


        [Theory]
        [InlineData(17)]
        [InlineData(100)]
        [InlineData(34)]
        public void When_Products_Are_Passed_Return_Total_Price(int price)
        {
            //Arrange
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
            var products = new List<Product>();

            //Act
            var result = _sut.Checkout(products);

            //Assert
            Assert.Equal(0, result);
        }

    }
}
