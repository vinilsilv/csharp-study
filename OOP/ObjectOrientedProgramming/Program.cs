using System;
using System.Globalization;

namespace ObjectOrientedProgramming // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Create a program that recieves the size of two triangles' sides (X and Y)
             and then display the area values from both, and which one is bigger than the other.

            To calculate a triangle's area, the program will make use of the Heron's formula
             */

            Triangle x, y;

            x = new Triangle();
            y = new Triangle();
            

            Console.WriteLine("Insert values (triangle X):");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insert values (triangle Y):");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            
            p = (y.A + y.B + y.C) / 2;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine($"Triangle X's area = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Triangle Y's area = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY)
            {
                Console.WriteLine("The first triangle's (X) area is bigger");
            }
            else if (areaX == areaY)
            {
                Console.WriteLine("The triangles have the same size");
            }
            else
            {
                Console.WriteLine("The second triangle's (Y) area is bigger");
            }

        }
    }
}