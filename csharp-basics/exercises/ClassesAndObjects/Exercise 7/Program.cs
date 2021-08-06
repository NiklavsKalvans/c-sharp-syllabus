using System;

namespace Exercise_7
{
    class DogTest
    {
        static void Main(string[] args)
        {
            string sex1 = "male";
            string sex2 = "female";
            string[] names = { "Max", "Rocky", "Sparky", "Buster", "Sam", "Lady", "Molly", "Coco" };
            Dog dog1 = new Dog(names[0], sex1);
            Dog dog2 = new Dog(names[1], sex1);
            Dog dog3 = new Dog(names[2], sex1);
            Dog dog4 = new Dog(names[3], sex1);
            Dog dog5 = new Dog(names[4], sex1);
            Dog dog6 = new Dog(names[5], sex2);
            Dog dog7 = new Dog(names[6], sex2);
            Dog dog8 = new Dog(names[7], sex2);

            dog1._father = dog2._name;
            dog1._mother = dog6._name;
            dog8._father = dog4._name;
            dog8._mother = dog7._name;
            dog2._father = dog5._name;
            dog2._mother = dog7._name;
            dog4._father = dog3._name;
            dog4._mother = dog6._name;

            Dog.FathersName(dog8);
            Dog.FathersName(dog3);
            Console.WriteLine(Dog.HasSameMotherAs(dog8, dog2));
        }
    }
}
