using CoffeeShopOrder.Domain.Entities;

namespace CoffeeShopOrder.Test.Shared.Fixtures.Entities
{
    public class CoffeeFixtures
    {
        private string _name = "Natural";
        private double _weight = 1.5;
        private string _description = "Good";
        private int _calories = 1;

        public static CoffeeFixtures New() => new CoffeeFixtures();

        public Coffee Default()
        {
            return new Coffee(_name, _weight, _description, _calories);
        }

        public CoffeeFixtures WithName(string name)
        {
            _name = name;
            return this;
        }

        public CoffeeFixtures WithWeight(double weight)
        {
            _weight = weight;
            return this;
        }

        public CoffeeFixtures WithDescription(string description)
        {
            _description = description;
            return this;
        }

        public CoffeeFixtures WithCalories(int calories)
        {
            _calories = calories;
            return this;
        }
    }
}