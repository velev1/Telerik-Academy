//Problem 8. Catalan Numbers

//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (1 < n < 100).
//Examples:

//n	Catalan(n)
//0	1
//5	42
//10	16796
//15	9694845


namespace CatalanNumbers
{
    using System;
    using System.Numerics;

    class CatalanNumbers
    {
        static void Main()
        {
            int n = 0;            
            bool nParseOk = true;           
            bool isInRange = true;

            do
            {
                Console.Write("Enter number 1 < n < 100: ");
                string valueN = Console.ReadLine();
                nParseOk = int.TryParse(valueN, out n);               
                isInRange = ((n < 2) || (n > 99));

                Console.WriteLine();
            }
            while ((nParseOk == false) || (isInRange == true));

            int doubleN = 2 * n;

            BigInteger result1 = 1;

            for (int i = n + 1; i <= doubleN; i++)
            {
                result1 = result1 * i;

            }

            BigInteger result2 = 1;

            n = n + 1;
            for (int j = 1; j <= n; j++)
            {
                result2 = result2 * j;
            }

            BigInteger CtalanNumber = result1 / result2;
            
            Console.WriteLine("Catalan number of {0} = {1}", (n - 1), CtalanNumber);

            

        }
    }
}
