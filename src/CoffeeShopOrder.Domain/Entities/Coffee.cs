using CoffeeShopOrder.Domain.Common;

namespace CoffeeShopOrder.Domain.Entities
{
    public class Coffee : EntityBase
    {
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public string Description { get; private set; }
        public int Calories { get; private set; }

        public Coffee(string name, double weight, string description, int calories)
        {
            Name = name;
            Weight = weight;
            Description = description;
            Calories = calories;
        }

        public override List<string> Validate()
        {
            List<string> result = new List<string>() { };

            if (Name.Length == 0)
                result.Add("Name invalid");

            if (Weight == 0)
                result.Add("Weight invalid");

            if (Description.Length == 0)
                result.Add("Description invalid");

            if (Calories == 0)
                result.Add("Calories invalid");

            return result;
        }
    }
}
