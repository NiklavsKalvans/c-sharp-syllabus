using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Student : Person
    {
        private double _gpa;
        public Student (double gpa)
        {
            _gpa = gpa;
        }

        public Student (string firstName, string lastName, string adress, int id, double gpa)
        {
            _gpa = gpa;
            _firstName = firstName;
            _lastName = lastName;
            _adress = adress;
            _id = id;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"And my gpa is {_gpa}");
        }
    }
}
