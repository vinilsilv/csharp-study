﻿namespace Sphere
{
    internal class Calculator
    {
        public double Pi = 3.14;

        public double Circumference(double radius)
        {
            return 2 * Pi * radius;
        }

        public double Volume(double radius)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(radius, 3);
        }
    }
}
