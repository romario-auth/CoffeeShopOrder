using CoffeeShopOrder.Domain.Entities;
using CoffeeShopOrder.Test.Shared.Fixtures.Entities;
using Xunit;

namespace CoffeeShopOrder.Test.Entities
{
    public class OrderTest
    {
        [Fact]
        public void IsOrderValid_ThenResultTrue()
        {
            // Arange
            Order order = OrderFixtures.New().Builder();

            // Act
            var orderResult = order.IsValid();

            // Assert
            Assert.True(orderResult);
        }

        [Fact]
        public void IsTotalPriceInValid_ThenWeightInvalid()
        {
            // Arange
            decimal totalPrice = -10;
            string message = "Total Price invalid";
            Order order = OrderFixtures.New().WithTotalPrice(totalPrice).Builder();

            // Act
            var orderResult = order.Validate().FirstOrDefault();

            // Assert
            Assert.Equal(message, orderResult);
        }
    }
}
