using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            const double cmToInches = 2.54;
            const double kgToPounds = 2.205;
            Console.WriteLine("Enter your height(cm) and weight(kg)!");
            int height = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());
            double heightInInches = height / cmToInches;
            double weightInPounds = weight * kgToPounds;
            double bmi = (weightInPounds * 703) / (heightInInches * heightInInches);
            Console.WriteLine($"Your body mass index is {Math.Round(bmi,2)}");
            if (bmi < 18.5)
                Console.WriteLine("You are underweight!");
            else if (bmi > 25)
                Console.WriteLine("You are overweight!");
            else
                Console.WriteLine("You are optimal weight");
        }
    }
}
