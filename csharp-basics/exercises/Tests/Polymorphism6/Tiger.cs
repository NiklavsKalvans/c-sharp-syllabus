using System;

namespace Hierarchy
{
    public class Tiger : Feline
    {
        private string _region;
        public Tiger (string type, string name, double weight, string region) : base(type, name, weight, region)
        {
            _region = region;
        }

        public override string MakeSound()
        {
            return "Rawrrr!";
        }

        public override void EatFood(Food food)
        {
            if (food is Meat) _foodEaten += food._quantity;
            else Console.WriteLine($"{_type} are not eating that type of food!");
        }

        public override string ToString()
        {
            return $"{_type} [{_name}, {_weight}, {_region}, {_foodEaten}]";
        }
    }
}
