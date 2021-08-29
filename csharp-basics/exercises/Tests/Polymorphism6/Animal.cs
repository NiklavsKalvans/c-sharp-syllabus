using System;

namespace Hierarchy
{
    public abstract class Animal
    {
        protected string _name;
        protected string _type;
        protected double _weight;
        public int _foodEaten;
        public Animal (string type, string name, double weight)
        {
            _type = type;
            _name = name;
            _weight = weight;
        }

        public virtual string MakeSound()
        {
            return "Sound!";
        }
        
        public virtual void EatFood(Food food)
        {
            _foodEaten += food._quantity;
        }
    }
}
