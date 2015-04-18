//Problem 14. Quick sort

//Write a program that sorts an array of integers using the Quick sort algorithm.

using System;
using System.Collections.Generic;
using System.Text;

//Този код е намерен от нета!!!

namespace CSharpSort
{
    class QuickSort
    {
        
        static public int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;

                while (numbers[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        struct QuickPosInfo
        {
            public int left;
            public int right;
        };

        static public void QuickSort_Iterative(int[] numbers, int left, int right)
        {
            if (left >= right)
                return; // Invalid index range

            List<QuickPosInfo> list = new List<QuickPosInfo>();

            QuickPosInfo info;
            info.left = left;
            info.right = right;
            list.Insert(list.Count, info);

            while (true)
            {
                if (list.Count == 0)
                    break;

                left = list[0].left;
                right = list[0].right;
                list.RemoveAt(0);

                int pivot = Partition(numbers, left, right);

                if (pivot > 1)
                {
                    info.left = left;
                    info.right = pivot - 1;
                    list.Insert(list.Count, info);
                }

                if (pivot + 1 < right)
                {
                    info.left = pivot + 1;
                    info.right = right;
                    list.Insert(list.Count, info);
                }
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            int len = numbers.Length;

            Console.WriteLine("QuickSort By Iterative Method");
            QuickSort_Iterative(numbers, 0, len - 1);
            for (int i = 0; i < 9; i++)
            {
                Console.Write(numbers[i]);
            }

            Console.WriteLine();
        }
    }
}
