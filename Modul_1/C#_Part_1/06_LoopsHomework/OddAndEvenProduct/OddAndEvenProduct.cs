//Problem 10. Odd and Even Product

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
//Examples:

//numbers	result
//2 1 1 6 3	yes
//product = 6	
//3 10 4 6 5 1	yes
//product = 60	
//4 3 2 5 2	no
//odd_product = 16	
//even_product = 15

namespace OddAndEvenProduct
{
    using System;
    using System.Linq;

    class OddAndEvenProduct
    {
        static void Main()
        {
            Console.Write("Please enter your numbers (separated by space: ");
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            int oddsProduct = 1;
            int evensProduct = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evensProduct = evensProduct * numbers[i];
                }
                else
                {
                    oddsProduct = oddsProduct * numbers[i];
                }
            }
            bool areEqual = oddsProduct == evensProduct;

            string result;

            if (areEqual == true)
            {
               result  = "is equal";
            }
            else
            {
                result = "is not equal";
            }
            Console.WriteLine("The product of odds ({0}) {1} to product of evens ({2})", oddsProduct, result, evensProduct);

        }
    }
}
