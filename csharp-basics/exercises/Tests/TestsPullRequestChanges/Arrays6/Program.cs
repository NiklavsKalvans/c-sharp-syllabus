using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays6
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = -7;
            var arr1 = RandomNumberArray();
            var arr2 = ArrayCopy(arr1);
            ReplaceLast(arr1, num);
            foreach (var item in arr1)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            foreach (var item in arr2)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }

        public static int[] ArrayCopy(int[] arr)
        {
            var arr2 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }
            return arr2;
        }

        public static int[] ReplaceLast(int[] arr, int num)
        {
            arr[arr.Length - 1] = num;
            return arr;
        }

        public static int[] RandomNumberArray()
        {
            const int min = 1;
            const int max = 100;
            var arr = new int[10];
            var random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(min, max);
            }
            return arr;
        }
    }
}
