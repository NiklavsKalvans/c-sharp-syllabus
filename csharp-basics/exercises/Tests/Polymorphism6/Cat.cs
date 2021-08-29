using System;

namespace Hierarchy
{
    public class Cat : Feline
    {
        private string _breed;
        public Cat (string type, string name, double weight, string region, string breed) : base(type, name, weight, region)
        {
            _breed = breed;
        }

        public override string MakeSound()
        {
            return "Meow!";
        }

        public override void EatFood(Food food)
        {
            _foodEaten += food._quantity;
        }

        public override string ToString()
        {
            return $"{_type} [{_name}, {_breed}, {_weight}, {_region}, {_foodEaten}]";
        }
    }
}
