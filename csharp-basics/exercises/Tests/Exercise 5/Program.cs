using System;

namespace Exercise_5
{
    class DateTest
    {
        static void Main(string[] args)
        {
            Date date = new Date(27, 6, 1997);
            Date.DisplayDate(date);
            date.year = 2021;
            Date.DisplayDate(date);
        }
    }
}
