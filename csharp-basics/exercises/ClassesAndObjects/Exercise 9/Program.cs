using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(2, 7);
            Point point2 = new Point(4, 9);
            Console.WriteLine($"Coordinates of the 1st point {point1._x} {point1._y}");
            Console.WriteLine($"Coordinates of the 2nd point {point2._x} {point2._y}");
            SwapPoints(point1, point2);
            Console.WriteLine("Coordinates ater swap:");
            Console.WriteLine($"Coordinates of the 1st point {point1._x} {point1._y}");
            Console.WriteLine($"Coordinates of the 2nd point {point2._x} {point2._y}");
        }

        public static void SwapPoints(Point a, Point b)
        {
            int placeHolderX = a._x;
            int placeHolderY = a._y;
            a._x = b._x;
            a._y = b._y;
            b._x = placeHolderX;
            b._y = placeHolderY;
        }
    }
}
