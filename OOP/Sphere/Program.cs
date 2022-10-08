using System;
using System.Diagnostics;
using System.Globalization;

namespace Sphere // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine("Insert radius value: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circumference(radius);

            Console.WriteLine("Circumference: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            double volume = Volume(radius);

            Console.WriteLine("Volume:" + volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Value of PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circumference(double radius)
        {
            return 2 * Pi * radius;
        }

        static double Volume(double radius)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(radius, 3);
        }
    }
}