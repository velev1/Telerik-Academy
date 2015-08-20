//Problem 6. Sum integers

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
//Example:

//input	output
//"43 68 9 23 318"

using System;
using System.Collections.Generic;
using System.Linq;


class SumIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter sequence of integers separated by one space:\n " );
        int sum = Console.ReadLine().Trim('"').
            Split(new char[] {' ', ',', '\t'}, StringSplitOptions.RemoveEmptyEntries).
            Select(int.Parse).
            ToArray().Sum();
        Console.WriteLine("\nThe sum of all integers is: {0}\n", sum);
    }
}


