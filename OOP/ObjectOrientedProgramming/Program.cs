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

            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Insert values (triangle X):");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insert values (triangle Y):");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
            
            p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

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