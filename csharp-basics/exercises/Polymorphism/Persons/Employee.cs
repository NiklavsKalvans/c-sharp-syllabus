using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Employee : Person
    {
        private string _jobTitle;
        public Employee(string jobTitle)
        {
            _jobTitle = jobTitle;
        }

        public Employee(string firstName, string lastName, string adress, int id, string jobTitle)
        {
            _firstName = firstName;
            _lastName = lastName;
            _adress = adress;
            _id = id;
            _jobTitle = jobTitle;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"And my job tittle is - {_jobTitle}");
        }
    }
}
