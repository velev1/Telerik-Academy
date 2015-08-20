//Problem 4. Multiplication Sign

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.
//Examples:

//a	    b	    c	    result
//5	    2	    2	    +
//-2	-2	    1	    +
//-2	4	    3	    -
//0	    -2.5	4	    0
//-1	-0.5   -5.1	    -


namespace MultiplicationSign
{
    using System;
    using System.Threading;
    using System.Globalization;

    class MultiplicationSign
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter number a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter number b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter number c: ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("Multiplication sign = 0");
            }
            else if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("Multiplication sign = +");
            }
            else if ( a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("Multiplication sign = -");
            }
            else if ( a < 0 && b > 0 && c > 0)
            {
                 Console.WriteLine("Result = -");
            }
            else if (a < 0 && b < 0 && c > 0)
            {
                Console.WriteLine("Result = +");
            }
            else if (a < 0 && b > 0 && c < 0)
            {
                Console.WriteLine("Result = +");
            }
            else if (a > 0 && b < 0 && c > 0)
            {
                Console.WriteLine("Result = -");
            }
            else if (a > 0 && b > 0 && c < 0)
            {
                Console.WriteLine("Result = -");
            }
          
        }
    }
}
