//Problem 3. Decimal to hexadecimal

//Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Write("Enter decima integer to convert: ");
        long dec = long.Parse(Console.ReadLine());
        long keepDec = dec;
        string hex = string.Empty;

        if (dec == 0)
        {
            Console.WriteLine("\nThe hexadecimal representation of decimal number 0 is: 0\n ");
        }
        else
        {
            while (dec > 0)
            {
                long reminder = dec % 16;
                dec = dec / 16;
                string rem = string.Empty;
                switch (reminder)
                {
                    case 1: rem = "1"; break;
                    case 2: rem = "2"; break;
                    case 3: rem = "3"; break;
                    case 4: rem = "4"; break;
                    case 5: rem = "5"; break;
                    case 6: rem = "6"; break;
                    case 7: rem = "7"; break;
                    case 8: rem = "8"; break;
                    case 9: rem = "9"; break;
                    case 10: rem = "A"; break;
                    case 11: rem = "B"; break;
                    case 12: rem = "C"; break;
                    case 13: rem = "D"; break;
                    case 14: rem = "E"; break;
                    case 15: rem = "F"; break;
                    default: rem = "0"; break;
                }
            }

            Console.WriteLine("\nThe hexadecimal representation of decimal number {0} is: {1}\n", keepDec, hex);
        }
    }
}

