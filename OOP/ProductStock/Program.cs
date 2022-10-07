using System;
using System.Globalization;

namespace ProductStock // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();

            Console.WriteLine("Insert product data: ");
            Console.Write("Name: ");
            p.Name = Console.ReadLine();

            Console.Write("Price: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Amount: ");
            p.Amount = int.Parse(Console.ReadLine());

            Console.WriteLine($"Product data: {p}");

            Console.Write("Type the amount of products to be added to the stock: ");
            int amount = int.Parse(Console.ReadLine());
            p.AddProducts(amount);

            Console.WriteLine($"Updated stock data: {p}");

            Console.Write("Type the amount of products to be removed from the stock: ");
            amount = int.Parse(Console.ReadLine());
            p.RemoveProducts(amount);

            Console.WriteLine($"Updated stock data: {p}");
        }
    }
}