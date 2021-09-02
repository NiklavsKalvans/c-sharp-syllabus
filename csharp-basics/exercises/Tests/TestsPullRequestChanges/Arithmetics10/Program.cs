using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetics10
{
    public class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                choice = getMenu();

                if (choice == 1)
                {
                    Console.WriteLine("You chose 1");
                    CalculateCircleArea();
                    Console.ReadKey();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("You chose 2");
                    CalculateRectangleArea();
                    Console.ReadKey();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("You chose 3");
                    CalculateTriangleArea();
                    Console.ReadKey();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Thanks for calculating!");
                    Console.ReadKey();
                }

            } while (choice != 4);
        }

        public static int getMenu()
        {

            int userChoice;

            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();

            int.TryParse(keyboard.KeyChar.ToString(), out userChoice);

            while (userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine("Please enter a valid range: 1, 2, 3, or 4: ");
                keyboard = Console.ReadKey();
                userChoice = keyboard.KeyChar;
            }

            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            Console.WriteLine("What is the circle's radius? ");
            var keyboard = Console.ReadLine();
            double.TryParse(keyboard, out var radius);

            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
        }

        public static void CalculateRectangleArea()
        {
            double length = 0;
            double width = 0;

            Console.WriteLine("Enter length? ");
            var keyboard = Console.ReadLine();
            double.TryParse(keyboard, out length);

            Console.WriteLine("Enter width? ");
            var keyboard1 = Console.ReadLine();
            double.TryParse(keyboard1, out width);

            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfRectangle(length, width));
        }

        public static void CalculateTriangleArea()
        {
            double ground = 0;
            double height = 0;

            Console.WriteLine("Enter length of the triangle's base? ");
            var keyboard = Console.ReadLine();
            double.TryParse(keyboard, out ground);

            Console.WriteLine("Enter triangle's height? ");
            var keyboard1 = Console.ReadLine();
            double.TryParse(keyboard1, out height);

            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfTriangle(ground, height));
        }
    }
}
