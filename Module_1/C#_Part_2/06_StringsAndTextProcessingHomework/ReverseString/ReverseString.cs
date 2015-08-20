//Problem 2. Reverse string

//Write a program that reads a string, reverses it and prints the result at the console.
//Example:

//input	output
//sample


using System;
using System.Collections.Generic;
//using System.Linq;


class ReverseString
{
    static void Main()
    {
        Console.Write("Enter something to reverse: ");
        string input = Console.ReadLine();
        char[] stringTocharArray = input.ToCharArray();
        Array.Reverse(stringTocharArray);
        Console.WriteLine(new string(stringTocharArray));
    }
}

