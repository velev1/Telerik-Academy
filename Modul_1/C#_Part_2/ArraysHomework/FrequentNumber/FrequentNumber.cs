//Problem 9. Frequent number

//Write a program that finds the most frequent number in an array.
//Example:

//input	                                    result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3     4 (5 times)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequentNumber
{
    class FrequentNumber
    {
        static void Main()
        {
            int[] arrayOfNumbers = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

            int maxCount = 0;
            int tempMaxCount = 0;
            int maxNumber = 0;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (i > (arrayOfNumbers.Length - maxCount))
                {
                    break;
                }

                for (int j = i; j < arrayOfNumbers.Length; j++)
                {
                    if (arrayOfNumbers[j] == arrayOfNumbers[i])
                    {
                        tempMaxCount++;
                    }
                }

                if (tempMaxCount > maxCount)
                {
                    maxCount = tempMaxCount;
                    maxNumber = arrayOfNumbers[i];
                }
                tempMaxCount = 0;
            }

            Console.WriteLine("{0} ({1} times)", maxNumber, maxCount);
        }
    }
}
