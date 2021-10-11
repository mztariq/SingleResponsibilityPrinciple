using ShoppingCart_With_SRP;
using System.Collections.Generic;
using Xunit;

namespace SRP.Tests.Unit
{
    public class CartManagementTests
    {

        [Fact]
        public void When_Products_Are_added_We_Should_ALways_Get_Three_Product_Back()
        {
            //Arrange
            var _sut = new CartManagement();

            //Act            
            var result = _sut.AddProductIntoCart();

            //Assert
            Assert.Equal(3, result.Count);
        }



         [Fact]
        public void When_Products_Are_Deleted_Should_Get_Correct_Products()
        {
            //Arrange
            var _sut = new CartManagement();           
            var products = _sut.AddProductIntoCart();

            //Act            
            var result = _sut.DeleteProductFromCart(products);

            //Assert
            Assert.DoesNotContain(result, x => x.Name == "Laptop");
        }
    }
}
