//Problem 1. Numbers from 1 to N

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
//Examples:

//n	output
//3	1 2 3
//5	1 2 3 4 5


namespace NumbersFromOneToN
{
    using System;

    class NumbersFromOneToN
    {
        static void Main()
        {
            Console.Write("Enter positive integer number: ");
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            while (number <= n)
            {
                Console.Write("{0} ", number);
                number++;
            }
            Console.WriteLine();

        }
    }
}
