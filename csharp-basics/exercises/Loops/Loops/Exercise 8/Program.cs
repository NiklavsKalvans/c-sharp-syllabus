using System;

namespace Exercise_8
{
    class AsciiFigure
    {
        static void Main(string[] args)
        {
            const int size = 5;
            int size0 = size * 4 - 4;
            int size1 = size * 4 -8;
            int size2 = 8;
            string lineFirst0 = new string('/',size0);
            string lineFirst1 = new string('\\', size0);
            Console.WriteLine(lineFirst0 + lineFirst1);
            for (int i = 0; i < size -2; i++)
            {
                string line1 = new String('/',size1);
                string line2 = new String('*', size2);
                string line3 = new String('\\', size1);
                Console.WriteLine(line1 + line2 + line3);
                size1 -= 4;
                size2 += 8;
            }
            string lineLast = new string ('*', size0 * 2);
            Console.WriteLine(lineLast);
        }
    }
}
