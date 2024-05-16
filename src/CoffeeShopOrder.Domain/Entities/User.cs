using CoffeeShopOrder.Domain.Common;

namespace CoffeeShopOrder.Domain.Entities
{
    public class User : EntityBase
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }

        public User(string name, string lastName, string email)
        {
            Name = name;
            LastName = lastName;
            Email = email;
        }

        public override List<string> Validate()
        {
            List<string> result = new List<string>() { };

            return result;
        }
    }
}
