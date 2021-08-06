using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Dog
    {
        public string _name;
        public string _sex;
        public string _father;
        public string _mother;
        public Dog(string name, string sex)
        {
            _name = name;
            _sex = sex;
            _father = "Unknown";
            _mother = "Unknown";
        }

        public static void FathersName(Dog dog)
        {
            Console.WriteLine(dog._father);
        }

        public static bool HasSameMotherAs(Dog dog1, Dog dog2)
        {
            return (dog1._mother == dog2._mother);
        }
    }
}
