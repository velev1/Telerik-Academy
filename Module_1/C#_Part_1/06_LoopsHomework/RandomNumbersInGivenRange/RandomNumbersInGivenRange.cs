//Problem 11. Random Numbers in Given Range

//Write a program that enters 3 integers n, min and max (min = max) and prints n random numbers in the range [min...max].
//Examples:

//n	min	max	random numbers
//5	0	1	1 0 0 1 1
//10	10	15	12 14 12 15 10 12 14 13 13 11
//Note: The above output is just an example. Due to randomness, your program most probably will produce different results.


namespace RandomNumbersInGivenRange
{
    using System;

    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            int n;
            int min;
            int max;
            bool nParseOK = true;
            bool minParseOK = true;
            bool maxParseOK = true;

            do
            {
                Console.Write("Enter desiered amount of random numbers n: ");
                string valueN = Console.ReadLine();
                nParseOK = int.TryParse(valueN, out n);
                Console.Write("Enter desiered min value of random number: ");
                string valueMin = Console.ReadLine();
                nParseOK = int.TryParse(valueMin, out min);
                Console.Write("Enter desiered max value of random number: ");
                string valueMax = Console.ReadLine();
                nParseOK = int.TryParse(valueMax, out max);

            } 
            while ((nParseOK == false) && (minParseOK == false) && (maxParseOK == false));
            Console.WriteLine();

            Random rnd = new Random();
            int rndNumb;

            for (int i = 0; i < n; i++)
            {
                rndNumb = rnd.Next(min, max);
                Console.Write("{0} ", rndNumb);
            }


        }
    }
}
