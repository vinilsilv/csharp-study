using System;
using System.Globalization;

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

            // SByte x = 100;
            // byte n1 = 255;
            // int n2 = 2147483647;
            // long n3 = 2147483648L;
            // float n4 = 4.5f;
            // double n5 = 4.5;
             
            // char initial = 'V';
            // char unicodeLetter = '\u0041';
            // string name = "Joe";
             
            // bool isTrue = false;
             
            // object obj1 = "Alex";
             
             
            // int maxVal = int.MaxValue;
            // int minVal = int.MinValue;
            // Works for int, sbyte, long, decimal, etc...

            // int age = 40;

            // Console.WriteLine("{0} is {1} years old.", name, age);
            // Console.WriteLine($"{name} is {age} years old.");
            // Console.WriteLine(name + " is " + age + " years old.");

            // string phrase = Console.ReadLine();

            // string[] vet = Console.ReadLine().Split(' ');

            // int num1 = int.Parse(Console.ReadLine());
            // char ch = char.Parse(Console.ReadLine());
            // double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string name = vet[0];
            char gender = char.Parse(vet[1]);
            int age = int.Parse(vet[2]);
            double height = double.Parse(vet[3], CultureInfo.InvariantCulture);


            Console.WriteLine(name);
            Console.WriteLine(gender);
            Console.WriteLine(age);
            Console.WriteLine(height);
        }
    }
}