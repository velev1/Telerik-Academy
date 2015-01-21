//Problem 4. Number Comparer

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.
//Examples:

//a	b	greater
//5	6	6
//10	5	10
//0	0	0
//-5	-2	-2
//1.5	1.6	1.6

namespace NumberComparer
{
    using System;
    using System.Threading;
    using System.Globalization;

    class NumberComparer
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Insert number A:");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.Write("Insert number B:");
            decimal b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Greater: {0}", a > b ? a : b);

        }
    }
}
