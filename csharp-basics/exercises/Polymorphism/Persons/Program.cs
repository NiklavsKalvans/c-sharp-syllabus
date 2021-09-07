using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Student("John","Wick","Mad street 2-11", 119, 4.2);
            person1.Display();
            var person2 = new Employee("Gordon", "Freeman", "Laboratory street 72-2", 12245, "Software Engineer");
            person2.Display();
        }
    }
}