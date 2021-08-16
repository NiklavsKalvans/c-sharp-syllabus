using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Dog
    {
        public string name;
        public string sex;
        public string father;
        public string mother;
        public Dog(string name1, string sex1)
        {
            name = name1;
            sex = sex1;
            father = "Unknown";
            mother = "Unknown";
        }

        public static void FathersName(Dog dog)
        {
            Console.WriteLine(dog.father);
        }

        public static bool HasSameMotherAs(Dog dog1, Dog dog2)
        {
            return (dog1.mother == dog2.mother);
        }
    }
}
