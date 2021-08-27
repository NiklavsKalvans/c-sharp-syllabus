using System;
using System.Collections.Generic;

namespace Polymorphism1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var audi = new Audi();
            var bmw = new Bmw();
            var tesla = new Tesla();
            var lexus = new Lexus();
            var kia = new Kia();
            var bugati = new Bugati();
            var cars = new List<ICar> { audi, bmw, tesla, lexus, kia, bugati };
            for (int i = 0; i < 10; i++)
            {
                foreach (var car in cars)
                {
                    if (i == 0) car.StartEngine();
                    if (i == 2)
                    {
                        var car2 = car as IBoost;
                        if (car2 != null) car2.UseNitrousOxideEngine();
                    }
                    car.SpeedUp();
                    if (i == 9) Console.WriteLine($"{car} final speed is {car.ShowCurrentSpeed()}");
                }
            }
            Console.ReadKey();
        }
    }
}