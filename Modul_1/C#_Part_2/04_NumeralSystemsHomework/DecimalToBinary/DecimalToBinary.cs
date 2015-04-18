//Problem 1. Decimal to binary

//Write a program to convert decimal numbers to their binary representation.


using System;

class DecimaToBinary
{
    static void Main()
    {
        Console.Write("Enter positive integer number: ");
        long dec = long.Parse(Console.ReadLine());
        long keepDec = dec;
        string bin = string.Empty;

        if (dec == 0)
        {
            Console.WriteLine("The binary representation of 0 is: 0");
        }
        else
        {
            while (dec > 0)
            {
                long rem = dec % 2;
                dec = dec / 2;
                bin = rem + bin;
            }

            Console.WriteLine("\nThe binary representation of {0} is: {1}\n", keepDec, bin);
        }
    }
}

