using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Logitech mouse", 70.00, 14);
            Product product2 = new Product("iPhone 5s", 999.99, 3);
            Product product3 = new Product("Epson EB-U05", 440.46, 1);

            Console.WriteLine(product1.PrintProduct());
            Console.WriteLine(product2.PrintProduct());
            Console.WriteLine(product3.PrintProduct());

            product1.ChangePrice(59.00);
            product1.ChangeAmount(4);
            Console.WriteLine(product1.PrintProduct());
        }
    }
}
