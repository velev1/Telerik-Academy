//Problem 16. Decimal to Hexadecimal Number

//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Examples:

//decimal	    hexadecimal
//254	        FE
//6883	        1AE3
//338583669684  4ED528CBB4


namespace DecimalToHexadecimalNumber
{
    using System;

    class DecimalToHexadecimalNumber
    {
        static void Main()
        {
            Console.Write("Enter decima integer to convert: ");
            long dec = long.Parse(Console.ReadLine());
            long keepDec = dec;
            string hex = "";

            if (dec == 0)
            {
                Console.WriteLine("The hexadecimal representation of decimal number 0 is: 0 ");
            }
            else
            {
                while (dec > 0)
                {
                    long reminder = dec % 16;
                    dec = dec / 16;
                    string rem = "";
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

                    hex = rem + hex;

                }
                Console.WriteLine("The hexadecimal representation of decimal number {0} is: {1}", keepDec, hex);

            }
            

        }
    }
}
