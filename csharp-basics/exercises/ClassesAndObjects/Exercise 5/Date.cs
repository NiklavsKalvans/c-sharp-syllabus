using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Date
    {
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }

        public Date(int day1, int month1, int year1)
        {
            day = day1;
            month = month1;
            year = year1;
        }

        public static void DisplayDate(Date date)
        {
           Console.WriteLine($"{date.day}/{date.month}/{date.year}");
        }
    }
}
