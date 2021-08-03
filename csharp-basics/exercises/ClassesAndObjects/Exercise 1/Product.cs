using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Product
    {
        string name;
        double priceAtStart;
        int amountAtStart;
        public Product(string name, double priceAtStart, int amountAtStart)
        {
            this.name = name;
            this.priceAtStart = priceAtStart;
            this.amountAtStart = amountAtStart;
        }
        public void PrintProduct()
        {
            Console.WriteLine($"{name}, price {priceAtStart}, amount {amountAtStart}");
        }
        public void ChangePrice(double newPrice)
        {
            this.priceAtStart = newPrice;
        }
        public void ChangeAmount(int newAmount)
        {
            this.amountAtStart = newAmount;
        }
    }
}
