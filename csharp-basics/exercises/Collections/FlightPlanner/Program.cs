using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../../flights.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            var citiesAndDestinations = new Dictionary<string, string>();
            var cities = new List<string>();
            var route = new List<string>();
            bool isTraveling = true;
            for (int i = 0; i < readText.Length; i++)
            {
                var split = readText[i].Split('-');
                split[0] = split[0].Trim();
                split[1] = split[1].Remove(1, 1); ;
                if (citiesAndDestinations.ContainsKey(split[0]))
                    citiesAndDestinations[split[0]] += split[1];      
                else
                    citiesAndDestinations.Add(split[0], split[1]);
            }

            Console.WriteLine("Here you can see the cities you can start your trip at! Select one!(1-6)");
            foreach (KeyValuePair<string, string> kvp in citiesAndDestinations)
            {
                Console.WriteLine(kvp.Key);
                cities.Add(kvp.Key);
            }

            int input = int.Parse(Console.ReadLine());
            int pushToDefault = 7;
            while (isTraveling)
            {
                switch (input)
                {
                    case 1:
                    {
                        Travel(input, route, cities, citiesAndDestinations);
                        if (route[0] == cities[input - 1] && route.Count > 1)
                        {
                            isTraveling = false;
                            break;
                        }
                        input = int.Parse(Console.ReadLine());
                        if (input != 6 && input != 3) input = pushToDefault;
                        break;
                    }
                    case 2:
                    {
                        Travel(input, route, cities, citiesAndDestinations);
                        if (route[0] == cities[input - 1] && route.Count > 1)
                        {
                            isTraveling = false;
                            break;
                        }
                        input = int.Parse(Console.ReadLine());
                        if (input != 3 && input != 1 && input != 6 && input != 4) input = pushToDefault;
                        break;
                    }
                    case 3:
                    {
                        Travel(input, route, cities, citiesAndDestinations);
                        if (route[0] == cities[input - 1] && route.Count > 1)
                        {
                            isTraveling = false;
                            break;
                        }
                        input = int.Parse(Console.ReadLine());
                        if (input != 2 && input != 1) input = pushToDefault;
                        break;
                    }
                    case 4:
                    {
                        Travel(input, route, cities, citiesAndDestinations);
                        if (route[0] == cities[input - 1] && route.Count > 1)
                        {
                            isTraveling = false;
                            break;
                        }
                        input = int.Parse(Console.ReadLine());
                        if (input != 2 && input != 6) input = pushToDefault;
                        break;
                    }
                    case 5:
                    {
                        Travel(input, route, cities, citiesAndDestinations);
                        if (route[0] == cities[input - 1] && route.Count > 1)
                        {
                            isTraveling = false;
                            break;
                        }
                        input = int.Parse(Console.ReadLine());
                        if (input != 1) input = pushToDefault;
                        break;
                    }
                    case 6:
                    {
                        Travel(input, route, cities, citiesAndDestinations);
                        if (route[0] == cities[input - 1] && route.Count > 1)
                        {
                            isTraveling = false;
                            break;
                        }
                        input = int.Parse(Console.ReadLine());
                        if (input != 2 && input != 4 && input != 5) input = pushToDefault;
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("You have selected an invalid option. You have to start over.");
                        isTraveling = false;
                        break;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("This was your travel route:");
            Console.WriteLine(string.Join("-> ", route));
            Console.ReadKey();
        }
        public static void Travel(int input, List<string> route, List<string> cities, Dictionary<string, string> citiesAndDestinations)
        {
            if (input == 1) Console.WriteLine($"You are at {cities[0]}. You can go to {citiesAndDestinations[cities[0]]} now!(6/3)");
            else if (input == 2) Console.WriteLine($"You are at {cities[1]}. You can go to {citiesAndDestinations[cities[1]]} now!(3/1/6/4)");
            else if (input == 3) Console.WriteLine($"You are at {cities[2]}. You can go to {citiesAndDestinations[cities[2]]} now!(2/1)");
            else if (input == 4) Console.WriteLine($"You are at {cities[3]}. You can go to {citiesAndDestinations[cities[3]]} now!(2/6)");
            else if (input == 5) Console.WriteLine($"You are at {cities[4]}. You can go to {citiesAndDestinations[cities[4]]} now!(1)");
            else if (input == 6) Console.WriteLine($"You are at {cities[5]}. You can go to {citiesAndDestinations[cities[5]]} now!(2/4/5)");
            route.Add(cities[input - 1]);
            if (route[0] == cities[input - 1] && route.Count > 1) Console.WriteLine("Your trip is finished!");
        }
    }
}
