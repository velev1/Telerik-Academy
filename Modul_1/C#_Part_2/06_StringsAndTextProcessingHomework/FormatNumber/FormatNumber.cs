//Problem 11. Format number

//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatNumber
{
    class FormatNumber
    {
        static void Main()
        {
            Console.Write("Insert some integer number (Int32): ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("\n{0,15:D}", number);
            Console.WriteLine("{0,15:X}", number);
            Console.WriteLine("{0,15:P0}", number/100m);
            Console.WriteLine("{0,15:E}\n", number);
        }
    }
}
