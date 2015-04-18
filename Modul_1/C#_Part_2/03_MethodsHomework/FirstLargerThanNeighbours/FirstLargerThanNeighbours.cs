using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main()
        {

            int[] numbersArray = { 1, 2, 3, 6, 5, 45, 54, 6, 48, 8, 9, 6, 52, 54, 65, 6, 6, 6, 6, 5, 8, 8 };

            bool noLargest = true;

            for (int i = 1; i < numbersArray.Length - 1; i++)
            {
                if (BestMiddle(numbersArray, i))
                {
                    Console.WriteLine("Number at position {0} is the first larger than its two neighbours in the array", i);
                    noLargest = false;
                    break;
                }
            }
            if (noLargest)
            {
                Console.WriteLine("-1");
            }
        }
        
        static bool BestMiddle(int[] array, int middPosition)
        {
                if (array[middPosition] > array[middPosition + 1] &&
                    array[middPosition] > array[middPosition - 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }
    }
}
