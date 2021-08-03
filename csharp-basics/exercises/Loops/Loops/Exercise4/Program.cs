using System;
namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};                       
            for (int i = 0; i<vowels.Length;i++) 
            {
                Console.Write(vowels[i]);
            }
            foreach (char element in vowels)
            {
                Console.Write($"{element}");
            }
            Console.ReadKey();
        }
    }
}
