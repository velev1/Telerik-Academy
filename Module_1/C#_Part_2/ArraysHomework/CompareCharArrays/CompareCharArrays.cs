//Problem 3. Compare char arrays

//Write a program that compares two char arrays lexicographically (letter by letter).
using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Enter length of the arrays : ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            char[] firstArray = new char[n];
            char[] secondArray = new char[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter first array \"character\" element number {0}: ", i + 1);
                firstArray[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter second array \"character\" element number {0}: ", i + 1);
                secondArray[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            int lex;

            for (int i = 0; i < n; i++)
            {
                lex = (firstArray[i].CompareTo(secondArray[i]));
                if (lex < 0)
                {
                    lex = lex * -1;
                    Console.WriteLine("The elemet {0} of second array is {1} position after the element {0} of first array", i + 1, lex);
                }
                else if (lex > 0)
                {
                    Console.WriteLine("The elemet {0} of second array is {1} position before the element {0} of first array", i + 1, lex);
                }
                else
                {
                    Console.WriteLine("The elemet {0} of second array is at the same position as element {0} of first array", i + 1);
                }
            }
    }
}

