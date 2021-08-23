using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    public class Program
    {
        const int _maxWeeklyHours = 60;
        const int _hoursTillOverTime = 40;
        const double _overTimeMultiplier = 1.5;
        const double _minSalary = 8.00;
        static void Main(string[] args)
        {
            var worker1 = "Employee 1";
            double workersPay1 = 7.50;
            double hoursWorked1 = 35;
            double salary1 = Convert.ToDouble(CalculateSalary(hoursWorked1, workersPay1));

            var worker2 = "Employee 2";
            double workersPay2 = 8.20;
            double hoursWorked2 = 47;
            double salary2 = Convert.ToDouble(CalculateSalary(hoursWorked2, workersPay2));

            var worker3 = "Employee 3";
            double workersPay3 = 10.00;
            double hoursWorked3 = 73;
            double salary3 = Convert.ToDouble(CalculateSalary(hoursWorked3, workersPay3));

            Console.WriteLine("Here is wage report of this month!");
            Console.WriteLine($"{worker1} made {salary1} this month.");
            Console.WriteLine($"{worker2} made {salary2} this month.");
            Console.WriteLine($"{worker3} made {salary3} this month.");
            Console.WriteLine("If your salary is 0, that means you worked too much or are not getting paid enough!");
            Console.ReadKey();
        }
        public static double? CalculateSalary(double hoursWorked, double workersPay)
        {
            if (hoursWorked > _maxWeeklyHours || workersPay < _minSalary)
            {
                return null;
            }
            else if (hoursWorked <= _hoursTillOverTime)
            {
                return hoursWorked * workersPay;
            }
            else return (_hoursTillOverTime * workersPay) + (hoursWorked - _hoursTillOverTime) * (workersPay * _overTimeMultiplier);
        }
    }
}
