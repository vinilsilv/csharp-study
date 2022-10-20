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
        private string _name;
        private double _price;
        private int _amount;

        public Product()
        {
        }

        public Product(string name, double price, int amount) : this()
        {
            _name = name;
            _price = price;
            _amount = amount;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            if (name != null && name.Length > 1)
            {
                _name = name;
            }
        }

        public double GetPrice()
        {
            return _price;
        }

        public int GetAmount()
        {
            return _amount;
        }

        public double InStockTotalValue() {
            return _price * _amount;
        }

        public void AddProducts(int amount)
        {
            _amount += amount;
        }

        public void RemoveProducts(int amount)
        {
            _amount -= amount;
        }

        public override string ToString()
        {
            return $"{_name}, $ {_price.ToString("F2", CultureInfo.InvariantCulture)}, {_amount} units, Total: $ {InStockTotalValue().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
