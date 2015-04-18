//Problem 1. Square root

//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SquareRoot
{
    static void Main()
    {
        try
        {
            Console.Write("Enter number to calculate it's SQRT: ");
            double num = double.Parse(Console.ReadLine());
            double result = Math.Sqrt(num);
            Console.WriteLine(result);
        }
        catch (NotFiniteNumberException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Goog bye");
        }
    }
}

