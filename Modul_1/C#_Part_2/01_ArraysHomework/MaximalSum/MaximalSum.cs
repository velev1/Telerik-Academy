//Problem 8. Maximal sum

//Write a program that finds the sequence of maximal sum in given array.
//Example:

//input	                                result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8	    2, -1, 6, 4
//Can you do it with only one loop (with single scan through the elements of the array)?

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalSum
{
    static void Main()
    {
        int[] arrayOfNumbers = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        int currentSum = 0;
        int startIndex = 0;
        int endIndex = 0;
        int tempStartIndex = 0;
        int maxSum = arrayOfNumbers[0];

        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            if (currentSum < 0)
            {
              currentSum = arrayOfNumbers[i];
              tempStartIndex = i;
            }
            else  
            {
                currentSum += arrayOfNumbers[i];
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                startIndex = tempStartIndex;
                endIndex = i;
            }
        }

        Console.WriteLine("The maximal sum of subarray is {0}", maxSum);
        Console.WriteLine("The start index is {0}", startIndex);
        Console.WriteLine("The end index is {0}", endIndex);

        Console.WriteLine("The sub array with maximal sum is: ");

        for (int i = startIndex; i <= endIndex; i++)
        {
            if (i == endIndex)
            {
                Console.Write("{0}", arrayOfNumbers[i]);
            }
            else
	        {
                Console.Write("{0}, ",arrayOfNumbers[i] );
	        }
        }

        Console.WriteLine();
    }
}

