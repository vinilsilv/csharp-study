using System;
using System.Diagnostics;
using System.Globalization;

namespace Sphere // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Insert radius value: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = calc.Circumference(radius);
            double volume = calc.Volume(radius);

            Console.WriteLine("Circumference: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume:" + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Value of PI: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}