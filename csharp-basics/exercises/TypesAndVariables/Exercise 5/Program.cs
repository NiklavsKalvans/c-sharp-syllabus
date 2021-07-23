using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var course1 = "English III";
            var course2 = "Precalculus";
            var course3 = "Music Theory";
            var course4 = "Biotechnology";
            var course5 = "Principles of Technology I";
            var course6 = "Latin II";
            var course7 = "AP US History";
            var course8 = "Business Computer Infomation Systems";

            var teacher1 = "Ms. Lapan";
            var teacher2 = "Mrs. Gideon";
            var teacher3 = "Mr. Davis";
            var teacher4 = "Ms. Palmer";
            var teacher5 = "Ms. Garcia";
            var teacher6 = "Mrs. Barnett";
            var teacher7 = "Ms. Johannessen";
            var teacher8 = "Mr. James";

            Console.WriteLine("+------------------------------------------------------------+");
            Console.WriteLine($"Class - {course1}, teacher - {teacher1}.");
            Console.WriteLine($"Class - {course2}, teacher - {teacher2}.");
            Console.WriteLine($"Class - {course3}, teacher - {teacher3}.");
            Console.WriteLine($"Class - {course4}, teacher - {teacher4}.");
            Console.WriteLine($"Class - {course5}, teacher - {teacher5}.");
            Console.WriteLine($"Class - {course6}, teacher - {teacher6}.");
            Console.WriteLine($"Class - {course7}, teacher - {teacher7}.");
            Console.WriteLine($"Class - {course8}, teacher - {teacher8}.");
            Console.WriteLine("+------------------------------------------------------------+");
            Console.ReadKey();
        }
    }
}
