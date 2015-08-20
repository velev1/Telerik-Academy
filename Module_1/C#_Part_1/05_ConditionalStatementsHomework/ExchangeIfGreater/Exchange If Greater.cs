//Problem 1. Exchange If Greater

//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
//Examples:

//a	b	result
//5	2	2 5
//3	4	3 4
//5.5	4.5	4.5 5.5


namespace ExchangeIfGreater
{
    using System;
    using System.Threading;
    using System.Globalization;

    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter floating point number a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter floating point number b: ");
            double b = double.Parse(Console.ReadLine());

            if ( a > b )
            {
                Console.WriteLine("Result: {0} {1}", b, a);
            }
            else
            {
                Console.WriteLine("Result: {0} {1}", a, b);                
            }
        }
    }
}
