using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be a positive number");
            }
            double area = Convert.ToDouble(Math.PI) * (radius) * 2;
            return area;
        }

        public static double AreaOfRectangle(double length, double width)
        {
            if (length <= 0 || width <= 0)
            {
                throw new ArgumentException("Both lenght and width must be positive numbers");
            }
            double area = length * width;
            return area;
        }

        public static double AreaOfTriangle(double ground, double h)
        {
            if (ground <= 0 || h <= 0)
            {
                throw new ArgumentException("Both base and height must be positive numbers");
            }
            double area = h * ground * 0.5;
            return area;
        }
    }
}
