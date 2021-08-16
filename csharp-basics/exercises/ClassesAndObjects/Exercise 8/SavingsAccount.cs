using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class SavingsAccount
    {
        public double _balance;
        public double _AnnualInterestRate;
        public SavingsAccount (double balance)
        {
            _balance = balance;
        }

        public static void Withdraw(SavingsAccount a, double amount)
        {
            a._balance -= amount;
        }

        public static void Deposit(SavingsAccount a, double amount)
        {
            a._balance += amount;
        }

        public static void AddMonthlyInterest(SavingsAccount a)
        {
            a._balance += (a._AnnualInterestRate/12)*a._balance;
        }
    }
}
