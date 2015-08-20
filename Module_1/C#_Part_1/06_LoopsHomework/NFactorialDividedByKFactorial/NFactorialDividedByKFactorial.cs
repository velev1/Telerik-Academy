//Problem 6. Calculate N! / K!

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.
//Examples:

//n	k	n! / k!
//5	2	60
//6	5	6
//8	3	6720

namespace NFactorialDividedByKFactorial
{
    using System;

    using System.Numerics;

    class NFactorialDividedByKFactorial
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


            BigInteger result = 1;

            for (int i = k + 1 ; i <= n; i++)
            {
                result = result * i;
                
            }
            Console.WriteLine("n! / k! = {0}", result);
           

        }
    }
}
