using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the starting balace of your account!");
            double amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the annual interest rate!");
            double rate = double.Parse(Console.ReadLine());
            SavingsAccount acc = new SavingsAccount(amount);
            acc._AnnualInterestRate = rate;
            Console.WriteLine("Enter how many months would you like to leave the money to grow!");
            double months = double.Parse(Console.ReadLine());
            double deposited = 0;
            double withdrawn = 0;
           
            for (int i = 0; i < months; i++)
            {
                double input1;
                double input2;
                Console.WriteLine("How much you wish to deposit?");
                SavingsAccount.Deposit(acc, input1 = double.Parse(Console.ReadLine()));
                deposited += input1;
                Console.WriteLine("How much you wish to withdraw?");
                SavingsAccount.Withdraw(acc, input2 = double.Parse(Console.ReadLine()));
                withdrawn += input2;
                SavingsAccount.AddMonthlyInterest(acc);
            }
            double totalInterest = Math.Round(acc._balance - (amount + deposited), 2);
            Console.WriteLine($"Total deposited amount: {deposited}");
            Console.WriteLine($"Total withdrawn amount: {withdrawn}");
            Console.WriteLine($"Total interest earned: {totalInterest}");
            Console.WriteLine($"Final balance: {Math.Round(acc._balance, 2)}");
        }
    }
}
