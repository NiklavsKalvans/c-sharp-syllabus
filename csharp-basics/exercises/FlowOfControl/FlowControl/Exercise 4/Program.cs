using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number that represents a day in the week");
            //var input = Console.ReadLine();
            //if (Convert.ToInt32(input) == 1) Console.WriteLine("Monday");
            //else if (Convert.ToInt32(input) == 2) Console.WriteLine("Tuesday");
            //else if (Convert.ToInt32(input) == 3) Console.WriteLine("Wednesday");
            //else if (Convert.ToInt32(input) == 4) Console.WriteLine("Thursday");
            //else if (Convert.ToInt32(input) == 5) Console.WriteLine("Friday");
            //else if (Convert.ToInt32(input) == 6) Console.WriteLine("Saturday");
            //else if (Convert.ToInt32(input) == 7) Console.WriteLine("Sunday");
            //else Console.WriteLine("Not a valid day!");

            Console.WriteLine("Enter a number that represents a day in the week");
            var input1 = Console.ReadLine();
            switch (Convert.ToInt32(input1))
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wrdnesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Not a valid day!");
                    break;
            }
        }
    }
}
