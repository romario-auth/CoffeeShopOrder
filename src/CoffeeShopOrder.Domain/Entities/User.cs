using CoffeeShopOrder.Domain.Common;

namespace CoffeeShopOrder.Domain.Entities
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
