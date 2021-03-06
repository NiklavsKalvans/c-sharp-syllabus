using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            const int secondsInHour = 3600;
            const int secondsInMin = 60;
            const double MetersPerSecondToKmPerHour = 3.6;
            const double MetersPerSecondToMilesPerHour = 2.237;

            Console.WriteLine("Enter the distance traveled in meters!");
            var distanceInMeters = Console.ReadLine();

            Console.WriteLine("Enter the time it took in hours/minutes/seconds");
            var hours = Console.ReadLine();
            var minutes = Console.ReadLine();
            var seconds = Console.ReadLine();

            int totalTimeInSeconds = Convert.ToInt32(hours) * secondsInHour + Convert.ToInt32(minutes) * secondsInMin + Convert.ToInt32(seconds);
            double metersPerSecond = Convert.ToDouble(distanceInMeters) / totalTimeInSeconds;
            double kmPerHour = metersPerSecond * MetersPerSecondToKmPerHour;
            double milesPerHour = metersPerSecond * MetersPerSecondToMilesPerHour;
            
            Console.WriteLine($"You were traveling at {Math.Round(metersPerSecond,8)} meteres per second!");
            Console.WriteLine($"Wich is equal to {Math.Round(kmPerHour,8)} kilometers per hour!");
            Console.WriteLine($"For our American friends that is {Math.Round(milesPerHour,8)} miles per hour!");
        }
    }
}
