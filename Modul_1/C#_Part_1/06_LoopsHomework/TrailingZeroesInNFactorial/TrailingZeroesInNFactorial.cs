//Problem 18.* Trailing Zeroes in N!

//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.
//Examples:

//n	trailing zeroes of n!	explaination
//10	2	3628800
//20	4	2432902008176640000
//100000	24999	think why

namespace TrailingZeroesInNFactorial
{
    using System;
    using System.Numerics;

    class TrailingZeroesInNFactorial
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger zeroesCount = 0;

            for (BigInteger i = 5; n / i >= 1; i *= 5)
            {
                zeroesCount += n/i;
            }

            Console.WriteLine(zeroesCount);

        }
    }
}
