// BEGIN: 5f8c1d7c7d5c
using System;
using Xunit;

namespace Company.Function.Tests
{
    public class HttpTrigger1Tests
    {
        [Fact]
        public void ConvertToOrder_Returns_Order_Object()
        {
            // Arrange
            string requestBody = "{\"ProductID\":\"123\",\"OrderID\":\"456\",\"Quantity\":2}";

            // Act
            Order order = HttpTrigger1.ConvertToOrder(requestBody);

            // Assert
            Assert.Equal("123", order.ProductID);
            Assert.Equal("456", order.OrderID);
            Assert.Equal(2, order.Quantity);
        }

        [Fact]
        public void ConvertToOrder_Throws_Exception_When_RequestBody_Is_Null()
        {
            // Arrange
            string requestBody = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => HttpTrigger1.ConvertToOrder(requestBody));
        }

        [Fact]
        public void ConvertToOrder_Throws_Exception_When_RequestBody_Is_Invalid()
        {
            // Arrange
            string requestBody = "invalid request body";

            // Act & Assert
            Assert.Throws<JsonSerializationException>(() => HttpTrigger1.ConvertToOrder(requestBody));
        }
    }
}
// END: 5f8c1d7c7d5c