//Problem 14. Quick sort

//Write a program that sorts an array of integers using the Quick sort algorithm.

// Тука си е по алгоритъмът от wikipedia, собствена интерпретация :)

namespace QuickSort_v2
{
    using System;
    using System.Text;

    class QuickSort
    {
        static void Main()
        {
            int[] nonSortedArray = { 5, 7, 9, 8, 3, 6, 4, 1, 2, 0, 15, 11, 12, 14, 13, 10 ,19, 17, 16, 18, 20 };
            int low = 0;
            int high = nonSortedArray.Length - 1;

            int[] sortedArray = (int[])QSort(nonSortedArray, low, high).Clone();

            Console.WriteLine(String.Join(", ", sortedArray));
        }

        static int[] QSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int p = Partition(array, low, high);
                QSort(array, low, p - 1);
                QSort(array, p + 1, high);
            }
            
            return array;
        }

        static int Partition(int[] array, int low, int high)
        {
            int pivotIndex = ChoosePivot(array, low, high);
            int pivotValue = array[pivotIndex];

            int tempIndexValue = array[high];

            array[high] = array[pivotIndex];
            array[pivotIndex] = tempIndexValue;

            int storeIndex = low;

            for (int i = low; i < high; i++)
            {
                if (array[i] <= pivotValue)
                {
                    int tempValue = array[storeIndex];
                    array[storeIndex] = array[i];
                    array[i] = tempValue;
                    ++storeIndex;
                }
            }

            int tempPivot = array[high];
            array[high] = array[storeIndex];
            array[storeIndex] = tempPivot;
            
            return storeIndex;
        }

        static int ChoosePivot(int[] array, int low, int high)
        {
            if (high - low >= 3 )
            {
                if ((array[high] > array[low] && array[high] < array[(high + low) / 2]) ||
                    (array[high] < array[low] && array[high] > array[(high + low) / 2])) 
                {
                    return high;
                }
                else if ((array[high] < array[low] && array[low] < array[(high + low) / 2]) ||
                    (array[high] > array[low] && array[low] > array[(high + low) / 2]))
                {
                    return low;
                }
                else 
                {
                    return (high + low) / 2;
                }
            }
            else
            {
                return low;
            }
        }
    }
}
