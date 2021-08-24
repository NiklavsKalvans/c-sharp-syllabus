using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("Mack");
            names.Add("John");
            names.Add("Nick");
            names.Add("Josh");
            names.Add("Levy");
            names.Add("Darren");
            names.Add("Laura");
            names.Add("Cindy");
            names.Add("Sam");
            names.Add("Ella");

            names.Insert(4, "Luke");
            
            for (int i = 0; i<names.Count; i++)
            {
                if (names[i] == names[names.Count - 1])
                    names[i] = "Samantha";
            }
            
            names.Sort();
            
            if(names.Contains("Foobar"))
            {
                Console.WriteLine("Contains!");
            }
            else Console.WriteLine("Does not contain!");
            
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
