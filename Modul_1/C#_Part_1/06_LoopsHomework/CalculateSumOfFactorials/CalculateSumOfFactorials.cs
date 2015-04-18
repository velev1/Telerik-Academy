//Problem 5. Calculate 1 + 1!/X + 2!/X2 + … + N!/XN

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
//Use only one loop. Print the result with 5 digits after the decimal point.
//Examples:

//n	x	S
//3	2	2.75000
//4	3	2.07407
//5	-4	0.75781


namespace CalculateSumOfFactorials
{
    using System;
    using System.Numerics;
    class CalculateSumOfFactorials
    {
        static void Main()
        {
            int n;
            int x;
            bool parseSuccessN = true;
            bool paeseSuccessX = true;

            do
            {
                Console.Write("Enter n: ");
                string valueN = Console.ReadLine();
                parseSuccessN = int.TryParse(valueN, out n);
                Console.Write("Enter x: ");
                string valueX = Console.ReadLine();
                paeseSuccessX = int.TryParse(valueX, out x);
                Console.WriteLine();

            }
            while ((parseSuccessN == false) || (paeseSuccessX == false));

            decimal result = 0;
            decimal factorial = 1;
            decimal divFactorial = 0;

            for (int i = 1; i <= n; i++)
            {

                factorial = factorial * i;
                divFactorial = factorial / (decimal)(Math.Pow(x, i));
                result = result + divFactorial;

            }
            result = result + 1;
            Console.WriteLine("{0:F5}", result);

        }
    }
}


