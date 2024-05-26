using CoffeeShopOrder.Domain.Common;
using CoffeeShopOrder.Domain.Exceptions;

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

            if (Name.Length == 0)
                result.Add("Name invalid");

            if (LastName.Length == 0)
                result.Add("Last Name invalid");

            if (Email.Length == 0)
                result.Add("Email invalid");

            return result;
        }
    }
}
