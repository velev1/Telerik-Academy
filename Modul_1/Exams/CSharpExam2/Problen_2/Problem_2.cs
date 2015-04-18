using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Text.RegularExpressions;


class Problem_3
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine()); // number of lines

        for (int i = 0; i < T; i++)
			{

                long[] numbersInLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse).ToArray();
               
                Console.WriteLine(IsItIncreesing(numbersInLine));
			}
        

    }

    private static bool IsItIncreesing(long[] numbersInLine)
    {
        long[] newSec = new long[numbersInLine.Length - 1];

        for (int i = 1; i < numbersInLine.Length; i++)
        {
            newSec[i - 1] = Math.Max(numbersInLine[i], numbersInLine[i - 1]) - Math.Min(numbersInLine[i] , numbersInLine[i - 1]);
        }

        return AbsSec(newSec);
    }

    private static bool AbsSec(long[] input)
    {
        bool isTrue = true;
        for (int i = 1; i < input.Length; i++)
        {
            if (!(input[i] - input[i - 1] == 0 ||  input[i] - input[i - 1] == 1))
            {
                isTrue = false;
            }
            
        }


        return isTrue;
    }


}
