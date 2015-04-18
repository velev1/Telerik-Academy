//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaximalKSum
{
    static void Main()
    {
        
        
        Console.Write("Enter number of array's elements N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K elemets to check: ");
        int k = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter integer element {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int[] keepNumbers = (int[])numbers.Clone();
        int[] bestNumbersPosition = new int[k];

        int tempMaxValue = int.MinValue;
        
        int result = 0;

        for (int i = 0; i < k; i++)
        {
            for (int j  = 0; j < n; j++)
            {
                if (numbers[j] > tempMaxValue)
                {
                    tempMaxValue = numbers[j];
                    
                }
            }

            for (int h = 0; h < n; h++)
            {
                if (numbers[h] == tempMaxValue)
                {
                    numbers[h] = int.MinValue;
                    bestNumbersPosition[i] = h;
                    break;
                }
            }

            result += tempMaxValue;
            tempMaxValue = int.MinValue;
        }
        Console.WriteLine();

        Console.WriteLine("The maximum sum of {0} elements in the array is {1}", k, result);
        Console.WriteLine();

        Console.WriteLine("The {0} elements with higest valuues in the arry are: ", k);
        Console.WriteLine();

        for (int i = 0; i < k; i++)
        {
            Console.WriteLine("Positon {0} ->  vlaue {1}", bestNumbersPosition[i] + 1, keepNumbers[bestNumbersPosition[i]]);
            
        }
        Console.WriteLine();


    }
}

