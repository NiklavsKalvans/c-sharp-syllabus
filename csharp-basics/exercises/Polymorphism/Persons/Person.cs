using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Person
    {
        protected string _firstName { get; set; }
        protected string _lastName { get; set; }
        protected string _adress { get; set; }
        protected int _id { get; set; }

        public Person()
        {

        }

        public Person(string firstName, string lastName, string adress, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _adress = adress;
            _id = id;
        }
        public virtual void Display()
        {
            Console.WriteLine($"My name is {_firstName} {_lastName}, I live at {_adress} and my ID is {_id}");
        }
    }
}
