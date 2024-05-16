using CoffeeShopOrder.Domain.Common;

namespace CoffeeShopOrder.Domain.Entities
{
    public class Order : EntityBase
    {
        public Guid CoffeeId { get; private set; }
        public Coffee Coffee { get; private set; }
        public Guid UserId { get; private set; }
        public User User { get; private set; }
        public decimal TotalPrice { get; private set; }

        public Order(Coffee coffee,User user,decimal totalPrice)
        {
            Coffee = coffee;
            User = user;
            TotalPrice = totalPrice;
        }

        public override List<string> Validate()
        {
            List<string> result = new List<string>() { };

            return result;
        }
    }
}