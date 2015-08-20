//Problem 10. Find sum in array

//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:

//array	                    S	    result
//4, 3, 1, 4, 2, 5, 8       11	    4, 2, 5


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSumInArray
{
    class FindSumInArray
    {
        static void Main()
        {
            int[] arrayOfNumbers = { 4, 3, 1, 4, 2, 5, 8 };
            int wantedSum = 11;
            int currentSum = 0;
            int startIndex = 0;
            int endIndex = 0;
            bool solutionFound = false;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                for (int j = i; j < arrayOfNumbers.Length; j++)
                {
                    currentSum += arrayOfNumbers[j];
                    if (currentSum == wantedSum)
                    {
                        solutionFound = true;
                        startIndex = i;
                        endIndex = j;
                        break;
                    }
                    else if (currentSum > wantedSum)
                    {
                        break;
                    }
                }
                if (solutionFound)
                {
                    break;
                }
                else
                {
                    currentSum = 0;
                }
            }
            if (solutionFound)
            {
                Console.WriteLine("Solution foud");
                Console.WriteLine("Start index {0}", startIndex);
                Console.WriteLine("End index {0}", endIndex);

                for (int i = startIndex; i <= endIndex; i++)
                {
                    Console.Write("{0} ", arrayOfNumbers[i]);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No solution foud");
            }
        }
    }
}
