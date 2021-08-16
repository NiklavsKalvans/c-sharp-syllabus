using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        private string _name;
        public double _balance;

        public BankAccount (string name, double balance)
        {
            _name = name;
            _balance = balance;
        }

        public static string GetName(BankAccount acc)
        {
            return acc._name;
        }

        public static double GetBalance(BankAccount acc)
        {
            return acc._balance;
        }
    }
}
