using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Constructor
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Amount;

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public double InStockTotalValue() {
            return Price * Amount;
        }

        public void AddProducts(int amount)
        {
            Amount += amount;
        }

        public void RemoveProducts(int amount)
        {
            Amount -= amount;
        }

        public override string ToString()
        {
            return $"{Name}, $ {Price.ToString("F2", CultureInfo.InvariantCulture)}, {Amount} units, Total: $ {InStockTotalValue().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
