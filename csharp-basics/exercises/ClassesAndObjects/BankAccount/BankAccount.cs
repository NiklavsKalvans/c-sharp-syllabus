using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        public string _name;
        public double _balance;

        public BankAccount (string name, double balance)
        {
            _name = name;
            _balance = balance;
        }
    }
}
