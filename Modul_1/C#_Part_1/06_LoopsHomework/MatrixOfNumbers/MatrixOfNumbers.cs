//Problem 9. Matrix of Numbers

//Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.
//Examples:

//n = 2   matrix      n = 3   matrix      n = 4   matrix
//        1 2                 1 2 3               1 2 3 4
//        2 3                 2 3 4               2 3 4 5
//                            3 4 5               3 4 5 6
//                                                4 5 6 7


namespace MatrixOfNumbers
{
    using System;

    class MatrixOfNumbers
    {
        static void Main()
        {
            byte n;
            bool parseOkN = true;
            bool isInRange = true;

            do
            {
                Console.Write("Insert positive integer number 1<= n <= 20: ");
                string valueN = Console.ReadLine();
                parseOkN = byte.TryParse(valueN, out n);
                isInRange = ( n >= 1) && (n <= 20);
                
            } while ((isInRange == false) || (parseOkN == false));

            for (int row = 1; row <= n; row++)
            {
                for (int column = 1; column <= n; column++)
                {
                    Console.Write("{0} ", column);
                }
                Console.WriteLine();      
            }            
        }
    }
}
