using System;
using System.Globalization;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product("TV", 500.00, 10);
            p.SetName("");
            Console.WriteLine(p.GetName());
            Console.WriteLine(p.GetPrice());
            Console.WriteLine(p.GetAmount());
        }
    }
}