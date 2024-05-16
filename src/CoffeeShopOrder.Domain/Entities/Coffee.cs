using CoffeeShopOrder.Domain.Common;

namespace CoffeeShopOrder.Domain.Entities
{
    public class Coffee : EntityBase
    {
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public string Description { get; private set; }
        public int Calories { get; private set; }

        public Coffee() { }

        public Coffee(string name, double weight, string description, int calories)
        {
            Name = name;
            Weight = weight;
            Description = description;
            Calories = calories;
        }

    }
}
