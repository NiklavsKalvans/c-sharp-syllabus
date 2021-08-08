using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the names you want to add to a list");
            var names = new List<string>();
            bool isInput = true;
            while (isInput)
            {
                var inputs = Console.ReadLine();
                if (!string.IsNullOrEmpty(inputs))
                    names.Add(inputs);
                else isInput = false;
            }
            Console.WriteLine("Unique names in your list:");
            List<string> namesUnique = names.Distinct().ToList();
            Console.WriteLine(string.Join(",", namesUnique));
            Console.ReadKey();
        }
    }
}
