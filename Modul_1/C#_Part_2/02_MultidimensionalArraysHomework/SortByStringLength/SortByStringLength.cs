using System;


namespace SortByStringLength
{
    class SortByStringLength
    {
        static void Main()
        {
            string[] stringArray = {
                                     "aaa", "BBgB", "reccc", "ddwetd", "e",
                                     "arweaa", "B", "ccwwc", "dwredd", "eereree",
                                     "aaa", "BrrBB", "rrrwwccc", "dwrwdd", "eee" 
                                   };


            QSort(stringArray, 0, stringArray.Length - 1);
            PrintArray(stringArray);
        }

        static void PrintArray(string[] stringArray)
        {
            Console.WriteLine("Sotred array: \n");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
            Console.WriteLine();
        }

        static void QSort(string[] array, int low, int high)
        {
            if (low < high)
            {
                int p = Partition(array, low, high);
                QSort(array, low, p - 1);
                QSort(array, p + 1, high);
            }

            //return array;
        }

        static int Partition(string[] array, int low, int high)
        {
            int pivotIndex = ChoosePivot(array, low, high);
            int pivotValue = array[pivotIndex].Length;

            string tempIndexValue = array[high];

            array[high] = array[pivotIndex];
            array[pivotIndex] = tempIndexValue;

            int storeIndex = low;

            for (int i = low; i < high; i++)
            {
                if (array[i].Length <= pivotValue)
                {
                    string tempValue = array[storeIndex];
                    array[storeIndex] = array[i];
                    array[i] = tempValue;
                    ++storeIndex;
                }
            }

            string tempPivot = array[high];
            array[high] = array[storeIndex];
            array[storeIndex] = tempPivot;

            return storeIndex;
        }

        static int ChoosePivot(string[] array, int low, int high)
        {
            if (high - low >= 3)
            {
                if ((array[high].Length > array[low].Length && array[high].Length < array[(high + low) / 2].Length) ||
                    (array[high].Length < array[low].Length && array[high].Length > array[(high + low) / 2].Length))
                {
                    return high;
                }
                else if ((array[high].Length < array[low].Length && array[low].Length < array[(high + low) / 2].Length) ||
                    (array[high].Length > array[low].Length && array[low].Length > array[(high + low) / 2].Length))
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
