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

            // string[] vet = Console.ReadLine().Split(' ');
            // string name = vet[0];
            // char gender = char.Parse(vet[1]);
            // int age = int.Parse(vet[2]);
            // double height = double.Parse(vet[3], CultureInfo.InvariantCulture);

            // Console.WriteLine(name);
            // Console.WriteLine(gender);
            // Console.WriteLine(age);
            // Console.WriteLine(height);

            // int a = 10;
            // bool c1 = a < 10;
            // bool c2 = a > 10;
            // bool c3 = a <= 10;
            // bool c4 = a >= 10;
            // bool c5 = a == 10;
            // bool c6 = a != 10;

            // Console.WriteLine(c1);
            // Console.WriteLine(c2); 
            // Console.WriteLine(c3);
            // Console.WriteLine(c4);

            // bool c1 = 2 > 3 && 4 != 5;
            // bool c2 = 2 > 3 || 4 != 5;
            // bool c3 = !(2 > 3);

            // Console.WriteLine(c1);
            // Console.WriteLine(c2);
            // Console.WriteLine(c3);

            // bool c1 = true;
            // bool c2 = false;

            // if (c2)
            // {
            //     Console.WriteLine("First if");
            // }
            // else if (!c2 && !c1)
            // {
            //     Console.WriteLine("Second if");
            // }
            // else if (!c1)
            // {
            //     Console.WriteLine("Third if");
            // }
            // else
            // {
            //     Console.WriteLine("Fourth if");
            // }

            Console.WriteLine("Type three numbers:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double result = Greater(n1, n2, n3);
            Console.WriteLine($"The greater number is {result}");
        }

        static int Greater(int n1, int n2, int n3)
        {
            int greater;
            if (n1 > n2 && n1 > n3)
            {
                greater = n1;
            } else if (n2 > n1 && n2 > n3)
            {
                greater = n2;
            } else
            {
                greater = n3;
            }

            return greater;
        }
    }
}