using CoffeeShopOrder.Domain.Entities;
using CoffeeShopOrder.Test.Shared.Fixtures.Entities;
using Xunit;

namespace CoffeeShopOrder.Test.Entities
{
    public class CoffeeTest
    {
        [Fact]
        public void IsCoffeeValid_ThenResultTrue()
        {
            // Arange
            Coffee coffee = CoffeeFixtures.New().Default();

            // Act
            var coffeeResult = coffee.IsValid();

            // Asert
            Assert.True(coffeeResult);
        }

        [Fact]
        public void IsNameCoffeeInValid_ThenNameInvalid()
        {
            // Arange
            string name = "";
            string message = "Name invalid";
            Coffee coffee = CoffeeFixtures.New().WithName(name).Default();

            // Act
            var coffeeResult = coffee.Validate().FirstOrDefault();

            // Asert
            Assert.Equal(message, coffeeResult);
        }

        [Fact]
        public void IsDescriptionCoffeeInValid_ThenWeightInvalid()
        {
            // Arange
            double weight = 0;
            string message = "Weight invalid";
            Coffee coffee = CoffeeFixtures.New().WithWeight(weight).Default();

            // Act
            var coffeeResult = coffee.Validate().FirstOrDefault();

            // Asert
            Assert.Equal(message, coffeeResult);
        }

        [Fact]
        public void IsCaloriesCoffeeInValid_ThenDescriptionInvalid()
        {
            // Arange
            string description = "";
            string message = "Description invalid";
            Coffee coffee = CoffeeFixtures.New().WithDescription(description).Default();

            // Act
            var coffeeResult = coffee.Validate().FirstOrDefault();

            // Asert
            Assert.Equal(message, coffeeResult);
        }

        [Fact]
        public void IsCaloriesCoffeeInValid_ThenCaloriesInvalid()
        {
            // Arange
            int calories = 0;
            string message = "Calories invalid";
            Coffee coffee = CoffeeFixtures.New().WithCalories(calories).Default();

            // Act
            var coffeeResult = coffee.Validate().FirstOrDefault();

            // Asert
            Assert.Equal(message, coffeeResult);
        }
    }
}