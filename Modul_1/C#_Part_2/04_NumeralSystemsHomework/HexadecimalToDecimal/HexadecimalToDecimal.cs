//Problem 4. Hexadecimal to decimal

//Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Numerics;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number to convert: ");
        string hex = Console.ReadLine();
        int length = hex.Length;
        BigInteger inDec = 0;
        BigInteger result = 0;

        for (int i = 0; i < length; i++)
        {
            switch (hex[i])
            {
                case '1': inDec = 1 * (BigInteger)Math.Pow(16, length - i - 1); break;
                case '2': inDec = 2 * (BigInteger)Math.Pow(16, length - i - 1); break;
                case '3': inDec = 3 * (BigInteger)Math.Pow(16, length - i - 1); break;
                case '4': inDec = 4 * (BigInteger)Math.Pow(16, length - i - 1); break;
                case '5': inDec = 5 * (BigInteger)Math.Pow(16, length - i - 1); break;
                case '6': inDec = 6 * (BigInteger)Math.Pow(16, length - i - 1); break;
                case '7': inDec = 7 * (BigInteger)Math.Pow(16, length - i - 1); break;
                case '8': inDec = 8 * (BigInteger)Math.Pow(16, length - i - 1); break;
                case '9': inDec = 9 * (BigInteger)Math.Pow(16, length - i - 1); break;
                case 'A': inDec = 10 * (BigInteger)Math.Pow(16, length - i - 1); break;
                case 'B': inDec = 11 * (BigInteger)Math.Pow(16, length - i - 1); break;
                case 'C': inDec = 12 * (BigInteger)Math.Pow(16, length - i - 1); break;
                case 'D': inDec = 13 * (BigInteger)Math.Pow(16, length - i - 1); break;
                case 'E': inDec = 14 * (BigInteger)Math.Pow(16, length - i - 1); break;
                case 'F': inDec = 15 * (BigInteger)Math.Pow(16, length - i - 1); break;
                default: inDec = 0 * (BigInteger)Math.Pow(16, i); break;
            }

            result = result + inDec;
        }
        Console.WriteLine("\nThe decimal representation of {0} is: {1}\n", hex, result);        
    }
}

