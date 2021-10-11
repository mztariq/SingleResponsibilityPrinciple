using ShoppingCart_With_SRP;
using System.Collections.Generic;
using Xunit;

namespace SRP.Tests.Unit
{
    public class DiscountMasterTests
    {

        [Fact]
        public void When_Mobile_Product_Passed_Gets_result()
        {
            //Arrange
            var _sut = new DiscountMaster();
            var product = new Product{ Name = "Mobile", Price =  12};

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
            var _sut = new DiscountMaster();
            var product = new Product{ Name = name, Price =  12};

            //Act
            var result = _sut.CalculateDiscount(product);

            //Assert
            Assert.Equal(0, result);
        }
    }
}
