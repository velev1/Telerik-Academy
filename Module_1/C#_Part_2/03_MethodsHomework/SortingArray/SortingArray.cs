// Problem 9. Sorting array

// Write a method that return the maximal element in a portion of array of integers starting at given index.
// Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Collections.Generic;



class SortingArray
{
    static void Main()
    {
        int[] numbers = { 5, 7, 15, 2, 3, 6, 8, 77, 98, 56, 99, 22, 1, 6, 3, 7, 8, 5, 6, 9, 55, 2 };

        int startIndex = 3;
        int endIndex = 12;

        int maxIndex =  ArrayPortionMaxElement(numbers, startIndex, endIndex);
        Console.WriteLine("Max number {0} on index {1}",numbers[maxIndex], maxIndex  );
        
        SortDescending(numbers);
        Console.WriteLine("Sorted Descending: ");
        PrintArray(numbers);
        Console.WriteLine("Sorted Ascending: ");
        SortAscending(numbers);
        PrintArray(numbers);
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }

    static int ArrayPortionMaxElement(int[] array, int startIndex, int endIndex)
    {
        int maxIndex = startIndex;

        for (int i = startIndex; i <= endIndex; i++)
        {
            if (array[maxIndex] < array[i])
            {
                maxIndex = i;
            }            
        }

        return maxIndex; 
    }

    static void SortDescending(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int temp = array[i];
            int tempMaxIndex = ArrayPortionMaxElement(array, i, array.Length - 1);
            array[i] = array[tempMaxIndex];
            array[tempMaxIndex] = temp;  
        }
    }

    static void SortAscending(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int temp = array[array.Length - i - 1];
            int tempMaxIndex = ArrayPortionMaxElement(array, 0, array.Length - 1 - i);
            array[array.Length - i - 1] = array[tempMaxIndex];
            array[tempMaxIndex] = temp;
        }
    }
}


