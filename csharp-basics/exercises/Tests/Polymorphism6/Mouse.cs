using System;

namespace Hierarchy
{
    public class Mouse : Mammal
    {
        public Mouse (string type, string name, double weight, string region) : base(type, name, weight, region)
        {

        }

        public override string MakeSound()
        {
            return "skrp-skrp!";
        }

        public override void EatFood(Food food)
        {
            if (food is Vegetable) _foodEaten += food._quantity;
            else Console.WriteLine($"{_type} are not eating that type of food!");
        }

        public override string ToString()
        {
            return $"{_type} [{_name}, {_weight}, {_region}, {_foodEaten}]";
        }
    }
}
