using System;

namespace Product1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            int product = 1;
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            Console.WriteLine(product);
        }
    }
}
