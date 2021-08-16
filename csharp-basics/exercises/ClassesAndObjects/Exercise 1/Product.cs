using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Product
    {
        private string _name;
        private double _priceAtStart;
        private int _amountAtStart;
        public Product(string name, double priceAtStart, int amountAtStart)
        {
            _name = name;
            _priceAtStart = priceAtStart;
            _amountAtStart = amountAtStart;
        }
        public void PrintProduct()
        {
            Console.WriteLine($"{_name}, price {_priceAtStart}, amount {_amountAtStart}");
        }
        public void ChangePrice(double newPrice)
        {
            _priceAtStart = newPrice;
        }
        public void ChangeAmount(int newAmount)
        {
            _amountAtStart = newAmount;
        }
    }
}
