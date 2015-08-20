//Problem 2. Get largest number

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLargestNumber
{
    class GetLargestNumber
    {
        static void Main()
        {
            Console.Write("Enter first integer: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Enter third integer: ");
            int third = int.Parse(Console.ReadLine());

            int max = GetMax(first, second);
            max = GetMax(max, third);

            Console.WriteLine("The biggest number is {0}", max);
        }

        static int GetMax(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }

        }
    }
}
