using System;
using System.Diagnostics;
using System.Globalization;

namespace Sphere // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert radius value: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Calculator.Circumference(radius);
            double volume = Calculator.Volume(radius);

            Console.WriteLine("Circumference: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume:" + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Value of PI: " + Calculator.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}