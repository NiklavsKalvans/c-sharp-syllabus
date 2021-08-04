﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            int startKilometers;
            int liters;

            Car car = new Car(0);
            Car car1 = new Car(1200);

            Console.Write("Enter first reading: ");
            startKilometers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter liters reading: ");
            liters = Convert.ToInt32(Console.ReadLine());
            car.FillUp(startKilometers, liters);

            Console.Write("Enter first reading: ");
            startKilometers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter liters reading: ");
            liters = Convert.ToInt32(Console.ReadLine());
            car1.FillUp(startKilometers, liters);

            Console.WriteLine("Car kilometers per liter are " + car.CalculateConsumption() + " gasHog:" + car.GasHog());
            Console.WriteLine("Car1 Kilometers per liter are " + car1.CalculateConsumption() + " economyCar:" + car1.EconomyCar());
            Console.ReadKey();
        }
    }
}
