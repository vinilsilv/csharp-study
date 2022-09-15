using System;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SByte x = 100;
            //Console.WriteLine(x);
            //// 100

            //byte n1 = 255;
            //n1 = -255;
            // Error

            //n1++;
            //// Returns 0

            SByte x = 100;
            byte n1 = 255;
            int n2 = 2147483647;
            long n3 = 2147483648L;
            float n4 = 4.5f;
            double n5 = 4.5;

            char initial = 'V';
            char unicodeLetter = '\u0041';
            string name = "Joe";

            bool isTrue = false;

            object obj1 = "Alex";

            Console.WriteLine(obj1);

        }
    }
}