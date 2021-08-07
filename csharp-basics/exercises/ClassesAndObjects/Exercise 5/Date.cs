using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Date
    {
        public int _day { get; set; }
        public int _month { get; set; }
        public int _year { get; set; }

        public Date(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }

        public static void DisplayDate(Date date)
        {
           Console.WriteLine($"{date._day}/{date._month}/{date._year}");
        }
    }
}
