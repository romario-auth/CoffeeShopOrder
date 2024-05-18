using CoffeeShopOrder.Domain.Entities;
using CoffeeShopOrder.Test.Shared.Fixtures.Entities;
using Xunit;

namespace CoffeeShopOrder.Test.Entities
{
    public class UserTest
    {
        [Fact]
        public void IsUserValid_ThenResultTrue()
        {
            // Arange
            User user = UserFixtures.New().Builder();

            // Act
            var userResult = user.IsValid();

            // Asert
            Assert.True(userResult);
        }

        [Fact]
        public void IsNameUserInValid_ThenNameInvalid()
        {
            // Arange
            string name = "";
            string message = "Name invalid";
            User user = UserFixtures.New().WithName(name).Builder();

            // Act
            var userResult = user.Validate().FirstOrDefault();

            // Asert
            Assert.Equal(message, userResult);
        }

        [Fact]
        public void IsLastNameUserInValid_ThenNameInvalid()
        {
            // Arange
            string lastName = "";
            string message = "Last Name invalid";
            User user = UserFixtures.New().WithLastName(lastName).Builder();

            // Act
            var userResult = user.Validate().FirstOrDefault();

            // Asert
            Assert.Equal(message, userResult);
        }

        [Fact]
        public void IsEmailUserInValid_ThenNameInvalid()
        {
            // Arange
            string email = "";
            string message = "Email invalid";
            User user = UserFixtures.New().WithEmail(email).Builder();

            // Act
            var userResult = user.Validate().FirstOrDefault();

            // Asert
            Assert.Equal(message, userResult);
        }
    }
}
