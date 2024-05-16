using CoffeeShopOrder.Domain.Entities;
using Xunit;

namespace CoffeeShopOrder.Test.Entities
{
    public class OrderTest
    {
        [Fact]
        public void CreateOrder()
        {
            // Arange
            string name = "";
            double weight = 1.5;
            string description = "Very Good";
            int calories = 1;

            Coffee coffer = new Coffee(name, weight, description, calories);

            // Act
            Guid cofferId = coffer.Id;
            string cofferName = coffer.Name;

            // Asert
            Assert.True(coffer);
        }
    }
}