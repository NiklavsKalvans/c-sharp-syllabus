using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class DateTest
    {
        static void Main(string[] args)
        {
            Date date = new Date(27, 6, 1997);
            Console.WriteLine(Date.DisplayDate(date));
            date.year = 2021;
            Console.WriteLine(Date.DisplayDate(date));
        }
    }
}
