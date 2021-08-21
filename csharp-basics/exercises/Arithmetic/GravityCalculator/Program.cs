
using System;

namespace GravityCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            double fallingTime = 10.0;
            double finalPosition = CalculatePosition(fallingTime);
            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }

        public static double CalculatePosition(double time)
        {
            double gravity = -9.81;
            double initialVelocity = 0.0;
            double initialPosition = 0.0;
            return 0.5 * gravity * time * time + initialVelocity * time + initialPosition;
        }
    }
}
