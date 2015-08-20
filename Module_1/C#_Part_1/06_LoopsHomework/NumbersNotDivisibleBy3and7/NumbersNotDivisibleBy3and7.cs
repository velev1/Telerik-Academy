//Problem 2. Numbers Not Divisible by 3 and 7

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.
//Examples:

//n	output
//3	1 2
//10	1 2 4 5 8 10

namespace NumbersNotDivisibleBy3and7
{
    using System;
        
    class NumbersNotDivisibleBy3and7
    {
        static void Main()
        {
            Console.Write("Enter positive integer number: ");
            int n = int.Parse(Console.ReadLine());
            int numbers = 1;
            while (numbers <= n)
            {
                if ((numbers % 3 == 0) || (numbers % 7 == 0))
                {
                    numbers++;
                    continue;
                }
                Console.Write("{0} ", numbers);
                numbers++;
            }


        }
    }
}
