using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Tesla" };

            List<string> carsList = new List<string>(array);
            HashSet<string> carsHash = new HashSet<string>(array);
            Dictionary<string, string> carsDictionary = new Dictionary<string, string>();
            carsDictionary.Add("Audi", "Germany");
            carsDictionary.Add("BMW", "Germany");
            carsDictionary.Add("Honda", "Japan");
            carsDictionary.Add("Mercedes", "Germany");
            carsDictionary.Add("VolksWagen", "Germany");
            carsDictionary.Add("Tesla", "USA");

            foreach (KeyValuePair<string, string> kvp in carsDictionary)
            {
                Console.WriteLine($"{kvp.Key} {kvp.Value}");
            }
            Console.ReadKey();
        }
    }
}
