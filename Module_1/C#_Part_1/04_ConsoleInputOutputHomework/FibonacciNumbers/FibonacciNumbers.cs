//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note: You may need to learn how to use loops.

//Examples:

//n	    comments
//1	    0
//3	    0 1 1
//10	0 1 1 2 3 5 8 13 21 34


namespace FibonacciNumbers
{
    using System;

    class FibonacciNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long firstNum = 0;
            long secondNum = 1;
            long thirdNum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}, " , firstNum);
                thirdNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = thirdNum;
            }                    
                        
        }
    }
}
