//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SelectionSort
{
    static void Main()
    {
        // Вариант 1
        int[] arr = { 5, 1, 2, 6, 8, 3, 4 };
        int minValue = int.MaxValue;
        int minIndex = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            minValue = int.MaxValue;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (minValue > arr[j])
                {
                    minValue = arr[j];
                    minIndex = j;
                }
            }
            int temp = arr[i];
            arr[i] = minValue;
            arr[minIndex] = temp;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }


        //Вариант 2

        //Console.WriteLine("Enter integer elements of the array in one lane separated by ',' (each element can contain more than one symbol):");
        //Console.WriteLine();
        //string input = Console.ReadLine();
        //Console.WriteLine();

        //string[] arrayInput = input.Split(',');
        //int[] inputIntArray = new int[arrayInput.Length];

        //for (int i = 0; i < inputIntArray.Length; i++)
        //{
        //    inputIntArray[i] = int.Parse(arrayInput[i]);
        //}

        //int tempMinValue = int.MaxValue;
        //int tempMinPosition = 0;

        //for (int i = 0; i < inputIntArray.Length; i++)
        //{
        //    for (int j = i; j < inputIntArray.Length; j++)
        //    {
        //        if (inputIntArray[j] < tempMinValue)
        //        {
        //            tempMinValue = inputIntArray[j];
        //            tempMinPosition = j;
        //            //inpurIntArray[tempMinPosition];
        //        }
        //    }

        //    inputIntArray[tempMinPosition] = inputIntArray[i];
        //    inputIntArray[i] = tempMinValue;
        //    tempMinValue = int.MaxValue;
        //    tempMinPosition = i;
        //}

        //for (int i = 0; i < inputIntArray.Length; i++)
        //{
        //    if (i == inputIntArray.Length - 1)
        //    {
        //        Console.Write("{0}", inputIntArray[i]);
        //    }
        //    else
        //    {
        //        Console.Write("{0}, ", inputIntArray[i]);
        //    }
        //}

        //Console.WriteLine();
    }

}

