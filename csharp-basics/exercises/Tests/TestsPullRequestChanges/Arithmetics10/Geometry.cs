using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetics10
{
    public class Geometry
    {
        public static double AreaOfCircle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be a positive number");
            }
            return Convert.ToDouble(Math.PI) * (radius) * 2;
        }

        public static double AreaOfRectangle(double length, double width)
        {
            if (length <= 0 || width <= 0)
            {
                throw new ArgumentException("Both lenght and width must be positive numbers");
            }
            return length * width;
        }

        public static double AreaOfTriangle(double ground, double h)
        {
            if (ground <= 0 || h <= 0)
            {
                throw new ArgumentException("Both base and height must be positive numbers");
            }
            return h * ground * 0.5;
        }
    }
}
