//Problem 3. Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The number starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

//Example 1:

//number	output
//3	min = 1
//2	max = 5
//5	sum = 8
//1	avg = 2.67

namespace MinMaxSumAndAverageOfNNumbers
{
    using System;
         
    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()

        {
            Console.Write("Enter sequence length: ");
            int counter = int.Parse(Console.ReadLine());

            int max = int.MinValue;
            int min = int.MaxValue;
            int sum = 0;
            

            for (int i = 1; i <= counter; i++)
            {
                Console.Write("Enter number: ");
                int number = int.Parse(Console.ReadLine());

                if (max< number )
                {
                    max = number;
                }
                if (min > number)
                {
                    min = number;
                }

                sum = sum + number;
            }
            double avrage = (double)sum / (double)counter;
            Console.WriteLine("min: {0} " , min);
            Console.WriteLine("max: {0}" , max);
            Console.WriteLine("sum: {0}" , sum);
            Console.WriteLine("avrage: {0:F2}" , avrage);


        }   
    }
}
