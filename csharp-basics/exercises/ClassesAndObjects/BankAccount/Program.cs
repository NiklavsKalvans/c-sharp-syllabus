using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount("Rob", 250.5);
            string report = ShowUserNameAndBalance(acc1);
            Console.WriteLine(report);
            Console.ReadLine();
        }

        public static string ShowUserNameAndBalance(BankAccount acc)
        {
            if (BankAccount.GetBalance(acc) >= 0)
                return ($"{BankAccount.GetName(acc)}, $") + string.Format("{0:F2}", BankAccount.GetBalance(acc));
            else
                acc._balance *= -1;
                return ($"{BankAccount.GetName(acc)}, -$") + string.Format("{0:F2}", BankAccount.GetBalance(acc));
        }
    }
}
