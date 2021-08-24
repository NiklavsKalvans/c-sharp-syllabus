using System;
using System.Collections.Generic;

namespace Hierarchy
{
    class Program
    {
        static List<Animal> zoo = new List<Animal>();
        static void Main(string[] args)
        {
            Console.WriteLine("Lets make some animals and feed them!");
            var input = Console.ReadLine();
            while (input != "End")
            {
                var animal = ProcessAnimal(input);
                input = Console.ReadLine();
                var inputSplit = input.Split(" ");
                if (inputSplit[0] == "Vegetable")
                {
                    var food = new Vegetable(Convert.ToInt32(inputSplit[1]));
                    animal.EatFood(food);
                }
                else
                {
                    var food = new Meat(Convert.ToInt32(inputSplit[1]));
                    animal.EatFood(food);
                }
                Console.WriteLine(animal);
                input = Console.ReadLine();
            }

            foreach (var animal in zoo)
            {
                Console.Write($"{animal}, ");
            }
        }
        public static Animal ProcessAnimal(string input)
        {
            var inputSplit = input.Split(" ");
            if (inputSplit[0] == "Cat")
            {
                var cat = new Cat(inputSplit[0], inputSplit[1], Convert.ToDouble(inputSplit[2]), inputSplit[3], inputSplit[4]);
                zoo.Add(cat);
                cat.MakeSound();
                return cat;
            }
            else if (inputSplit[0] == "Tiger")
            {
                var tiger = new Tiger(inputSplit[0], inputSplit[1], Convert.ToDouble(inputSplit[2]), inputSplit[3]);
                zoo.Add(tiger);
                tiger.MakeSound();
                return tiger;
            }
            else if (inputSplit[0] == "Zebra")
            {
                var zebra = new Zebra(inputSplit[0], inputSplit[1], Convert.ToDouble(inputSplit[2]), inputSplit[3]);
                zoo.Add(zebra);
                zebra.MakeSound();
                return zebra;
            }
            else if (inputSplit[0] == "Mouse")
            {
                var mouse = new Mouse(inputSplit[0], inputSplit[1], Convert.ToDouble(inputSplit[2]), inputSplit[3]);
                zoo.Add(mouse);
                mouse.MakeSound();
                return mouse;
            }
            else return null;
        }
    }
}