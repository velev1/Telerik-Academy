//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
//Examples:

//numbers	sum
//1 2 3 4 5	15
//10 10 10 10 10	50
//1.5 3.14 8.2 -1 0	11.84


namespace SumOf5Numbers
{
    using System;
    using System.Linq;

    class SumOf5Numbers
    {
        static void Main()
        {
            Console.Write("Enter 5 numbers separeted by one space: ");
            string input = Console.ReadLine();
            


            string[] inputArray = input.Split(' ');
            int[] numbers = new int[inputArray.Length];

            for (int i = 0; i < numbers.Length; i++)
            { 
                numbers[i] = int.Parse(inputArray[i]);
            }

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}




//double[] numbers = input.Split(' ').Select(double.Parse).ToArray();
//double sum = numbers.Sum();
//Console.WriteLine("Sum: {0}", sum);

// Не обръщайте внимание на тези неща, просто си ги пазя :)
//char separator = ' ';
//int sepPossition = 0;
//sepPossition = input.IndexOf(separator, 2);
//Console.WriteLine(sepPossition);
//int firstNum = int.Parse(input.Substring(separator, separator + 1));
//Console.WriteLine(firstNum);