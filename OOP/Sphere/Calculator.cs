namespace Sphere
{
    internal class Calculator
    {
        public static double Pi = 3.14;

        public static double Circumference(double radius)
        {
            return 2 * Pi * radius;
        }

        public static double Volume(double radius)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(radius, 3);
        }
    }
}
