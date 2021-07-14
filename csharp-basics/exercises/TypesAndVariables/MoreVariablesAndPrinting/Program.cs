using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
        

            string Name = "Zed A. Shaw";
            int Age = 35;
            double Height = 74 * 2.54;  
            double Weight = Math.Round(180 * 0.453592, 2);
            string Eyes = "Blue";
            string Teeth = "White";
            string Hair = "Brown";

            Console.WriteLine("Let's talk about " + Name + ".");
            Console.WriteLine("He's " + Height + " centimeters tall.");
            Console.WriteLine("He's " + Weight + " kilos heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + Eyes + " eyes and " + Hair + " hair.");
            Console.WriteLine("His teeth are usually " + Teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + Age + ", " + Height + ", and " + Weight
                               + " I get " + (Age + Height + Weight) + ".");

            Console.ReadKey();
        }
    }
}