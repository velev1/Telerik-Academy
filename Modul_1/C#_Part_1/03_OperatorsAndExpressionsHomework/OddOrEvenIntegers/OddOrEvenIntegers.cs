//Problem 1. Odd or Even Integers

//Write an expression that checks if given integer is odd or even.
//Examples:

//n	Odd?
//3	true
//2	false
//-2	false
//-1	true
//0	false

namespace OddOrEvenIntegers
{
    using System;

    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.Write("Please enter integer number to check: ");
            int number = int.Parse(Console.ReadLine());
            bool isOdd = number % 2 != 0;
            Console.WriteLine("Is it odd?: {0}", isOdd);

        }
    }
}
