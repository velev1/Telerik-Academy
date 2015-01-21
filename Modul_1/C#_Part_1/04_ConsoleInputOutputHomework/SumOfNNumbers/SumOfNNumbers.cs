//Problem 9. Sum of n Numbers

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
//Examples:

//numbers	sum
//3	        90
//20	
//60	
//10
	
//5	        6.5
//2	
//-1	
//-0.5	
//4	
//2	

//1	        1
//1

namespace SumOfNNumbers
{
    using System;

    class SumOfNNumbers
    {
        static void Main()
        {
            Console.Write("Enter count of numbers:");
            int nCount = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < nCount; i++)
            {
                Console.Write("Enter integer number: ");
                int numbers = int.Parse(Console.ReadLine());
                sum = sum + numbers;
            }

            Console.WriteLine("Sum: {0}" , sum);
        }
    }
}
