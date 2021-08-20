using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int min = 1;
            const int max = 100;
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = new Random().Next(min, max);
                arr2[i] = arr1[i];
            }
            arr1[9] = -7;
            Console.WriteLine($"1sr array:{arr1[0]} {arr1[1]} {arr1[2]} {arr1[3]} {arr1[4]} {arr1[5]} {arr1[6]} {arr1[7]} {arr1[8]} {arr1[9]}");
            Console.WriteLine($"2nd array:{arr2[0]} {arr2[1]} {arr2[2]} {arr2[3]} {arr2[4]} {arr2[5]} {arr2[6]} {arr2[7]} {arr2[8]} {arr2[9]}");
            Console.ReadKey();
        }

        public static void CopyArrayAndReplaceLast(int[] arr1, int[] arr2, int num)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr2[i];
            }
            arr2[arr2.Length - 1] = num;
        }
    }
}
