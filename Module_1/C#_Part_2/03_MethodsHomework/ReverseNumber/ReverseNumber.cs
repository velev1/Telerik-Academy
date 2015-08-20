//Problem 7. Reverse number

//Write a method that reverses the digits of given decimal number.
//Example:

//input	    output
//256	    652
//123.45	54.321

using System;
using System.Globalization;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static void Main()
        {
            Console.Write("Enter number to reverse: ");
            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine("\nReversed: {0}\n", ReverseDecimal(number));
        }

        static decimal ReverseDecimal(decimal number)
        { 
            char[] charNumber = number.ToString().ToCharArray();
            Array.Reverse(charNumber);
            decimal reversed = decimal.Parse(new string(charNumber));
            return reversed;
        }
    }
}



