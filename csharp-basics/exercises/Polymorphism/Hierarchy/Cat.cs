using System;

namespace Hierarchy
{
    class Cat : Feline
    {
        private string _breed;
        public Cat (string type, string name, double weight, string region, string breed) : base(type, name, weight, region)
        {
            _breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
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
