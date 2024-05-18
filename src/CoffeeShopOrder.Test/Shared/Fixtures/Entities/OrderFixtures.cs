using CoffeeShopOrder.Domain.Entities;
using System.Xml.Linq;

namespace CoffeeShopOrder.Test.Shared.Fixtures.Entities
{
    public class OrderFixtures
    {
        private Coffee _coffee = CoffeeFixtures.New().Builder();
        private User _user = UserFixtures.New().Builder();
        private decimal _totalPrice = 10.20M;

        public static OrderFixtures New() => new OrderFixtures();

        public Order Builder()
        {
            return new Order(_coffee, _user, _totalPrice);
        }

        public OrderFixtures WithTotalPrice(decimal totalPrice)
        {
            _totalPrice = totalPrice;
            return this;
        }
    }
}
