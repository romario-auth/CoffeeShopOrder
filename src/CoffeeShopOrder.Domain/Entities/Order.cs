using CoffeeShopOrder.Domain.Common;

namespace CoffeeShopOrder.Domain.Entities
{
    public class Order : EntityBase
    {
        public Guid CoffeeId { get; set; }
        public Coffee Coffee { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public decimal TotalPrice { get; set; }
    }
}