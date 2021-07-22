using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string and i will convert it to a sequence of keypad digits");
            string input = Console.ReadLine();
            char[] inputSplitLower = input.ToLower().ToCharArray();
            for (int i = 0; i < inputSplitLower.Length; i++)
            {
                if (inputSplitLower[i] == 'a' || inputSplitLower[i] == 'b' || inputSplitLower[i] == 'c')
                {
                    Console.Write(2);
                }
                else if (inputSplitLower[i] == 'd' || inputSplitLower[i] == 'e' || inputSplitLower[i] == 'f')
                {
                    Console.Write(3);
                }
                else if (inputSplitLower[i] == 'g' || inputSplitLower[i] == 'h' || inputSplitLower[i] == 'i')
                {
                    Console.Write(4);
                }
                else if (inputSplitLower[i] == 'j' || inputSplitLower[i] == 'k' || inputSplitLower[i] == 'l')
                {
                    Console.Write(5);
                }
                else if (inputSplitLower[i] == 'm' || inputSplitLower[i] == 'n' || inputSplitLower[i] == 'o')
                {
                    Console.Write(6);
                }
                else if (inputSplitLower[i] == 'p' || inputSplitLower[i] == 'q' || inputSplitLower[i] == 'r' || inputSplitLower[i] == 's')
                {
                    Console.Write(7);
                }
                else if (inputSplitLower[i] == 't' || inputSplitLower[i] == 'u' || inputSplitLower[i] == 'v')
                {
                    Console.Write(8);
                }
                else if (inputSplitLower[i] == 'w' || inputSplitLower[i] == 'x' || inputSplitLower[i] == 'y' || inputSplitLower[i] == 'z')
                {
                    Console.Write(9);
                }
            }
            //Console.WriteLine("Enter a string and i will convert it to a sequence of keypad digits");
            //string input = Console.ReadLine();
            //var inputArray = input.ToLower().ToCharArray();
            //for (int i = 0; i < inputArray.Length; i++)
            //{
            //    switch (inputArray[i])
            //    {
            //        case 'a':
            //        case 'b':
            //        case 'c':
            //            Console.Write(2); break;
            //        case 'd':
            //        case 'e':
            //        case 'f':
            //            Console.Write(3); break;
            //        case 'g':
            //        case 'h':
            //        case 'i':
            //            Console.Write(4); break;
            //        case 'j':
            //        case 'k':
            //        case 'l':
            //            Console.Write(5); break;
            //        case 'm':
            //        case 'n':
            //        case 'o':
            //            Console.Write(6); break;
            //        case 'p':
            //        case 'q':
            //        case 'r':
            //        case 's':
            //            Console.Write(7); break;
            //        case 't':
            //        case 'u':
            //        case 'v':  
            //            Console.Write(8); break;
            //        case 'w':
            //        case 'x':
            //        case 'y':
            //        case 'z':
            //            Console.Write(9); break;

            //    }
            //}
        }
    }
}
