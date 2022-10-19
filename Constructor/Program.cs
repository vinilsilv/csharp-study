using System;
using System.Globalization;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert product data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // Console.Write("Amount in stock: ");
            // int amount = int.Parse(Console.ReadLine());

            Product p2 = new Product
            {
                Name = "TV",
                Price = 500,
                Amount = 20
            };

            Console.WriteLine();
            Console.WriteLine($"Product data: {p}");

            Console.WriteLine();
            Console.Write("Type the amount of products to be added to stock: ");
            int amount = int.Parse(Console.ReadLine());
            p.AddProducts(amount);

            Console.WriteLine();
            Console.WriteLine($"Updated data: {p}");

            Console.WriteLine();
            Console.Write("Type the amount of products to be removed from stock: ");
            amount = int.Parse(Console.ReadLine());
            p.RemoveProducts(amount);

            Console.WriteLine();
            Console.WriteLine($"Updated data: {p}");
        }
    }
}