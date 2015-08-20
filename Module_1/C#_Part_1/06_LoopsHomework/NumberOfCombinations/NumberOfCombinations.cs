//Problem 7. Calculate N! / (K! * (N-K)!)

//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
//Examples:

//n	k	n! / (k! * (n-k)!)
//3	2	3
//4	2	6
//10	6	210
//52	5	2598960


namespace NumberOfCombinations
{
    using System;
    using System.Numerics;

    class NumberOfCombinations
    {
        static void Main()
        {
            int n = 0;
            int k = 0;
            bool nParseOk = true;
            bool kParseOk = true;
            bool isInRange = true;

            do
            {
                Console.Write("Enter number n > 1: ");
                string valueN = Console.ReadLine();
                nParseOk = int.TryParse(valueN, out n);
                Console.Write("Enter number k < n < 100: ");
                string valueK = Console.ReadLine();
                nParseOk = int.TryParse(valueK, out k);
                isInRange = ((k >= n) || (k <= 1) || (k > 98) || (n < 3) || (n > 99));
                Console.WriteLine();
            }
            while (((nParseOk == false) || (kParseOk == false)) || (isInRange == true));

            BigInteger result1 = 1;

            for (int i = k + 1; i <= n; i++)
            {
                result1 = result1 * i;

            }
            
            BigInteger result2 = 1;
            int difference = n - k;

            for (int j = 1; j <= difference; j++)
            {
                result2 *= j;

            }

            BigInteger result3 = result1  / result2;
            Console.WriteLine("n! / (k! * (n-k)!) = " + result3);


        }
    }
}
