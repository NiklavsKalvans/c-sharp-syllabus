using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double areaOfCircle(decimal radius)
        {
            if (radius <= 0)
            {
                throw new Exception("Radius must be a positive number");
            }
            decimal area = Convert.ToDecimal(Math.PI) * (radius) * 2;
            return Convert.ToDouble(area);
        }

        public static double areaOfRectangle(decimal length, decimal width)
        {
            if (length <= 0 || width <= 0)
            {
                throw new Exception("Both lenght and width must be positive numbers");
            }
            decimal area = length * width;
            return Convert.ToDouble(area);
        }

        public static double areaOfTriangle(decimal ground, decimal h)
        {
            if (ground <= 0 || h <= 0)
            {
                throw new Exception("Both base and height must be positive numbers");
            }
            decimal area = h * ground * 0.5m;
            return Convert.ToDouble(area);
        }
    }
}
