// Problem 4. Binary search

// Write a program, that reads from the console an array of N integers and an integer K, 
// sorts the array and using the method Array.BinSearch() 
// finds the largest number in the array which is ≤ K.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinarySearch
{
    static void Main()
    {

        Console.Write("\nEnter count N of integer elements of the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("\nEnter K element: ");
        int k = int.Parse(Console.ReadLine());

        int[] intArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter elemrnt {0}/{1}: ", i + 1, n );
            intArray[i] = int.Parse(Console.ReadLine());
        }


        Array.Sort(intArray);

        int index = Array.BinarySearch(intArray, k);

        if (index < 0)
        {
            if (index != - 1)
            {
                index = -(index + 2);
            }
        }

        if (index != -1)
        {
            Console.WriteLine("\nFound number equal or smaller than {0} -> {1}\n", k ,intArray[index]);
        }
        else
        {
            Console.WriteLine("\nNot found numbe equal or smaller to {0} !!!\n", k);
        }
        
    }

   
}

