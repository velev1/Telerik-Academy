//Problem 1. Sum of 3 Numbers

//Write a program that reads 3 real numbers from the console and prints their sum.
//Examples:

//a	b	c	sum
//3	4	11	18
//-2	0	3	1
//5.5	4.5	20.1	30.1



namespace SumOf3Numbers
{
    using System;
    using System.Threading;
    using System.Globalization;

    class SumOf3Numbers
    {
        static void Main()
        { 

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.00} + {1:0.00} + {2:0.00} = {3:0.00}", a, b, c, a + b + c);
        }
    }
}
