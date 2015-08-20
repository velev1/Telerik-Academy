//Problem 5. Larger than neighbours

//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThaNeighbours
{
    class LargerThaNeighbours
    {
        static void Main()
        {
            int[] numbersArray = { 1, 2, 3, 6, 5, 45, 54, 6, 48, 8, 9, 6, 52, 54, 65, 6, 6, 6, 6, 5, 8, 8 };
            int positionToCheck = 0;

            if (positionToCheck == 0 || positionToCheck == numbersArray.Length -  1)
            {
                Console.WriteLine("Invalid position - there are NO two neighbours");
            }
            else
            {
                if (BestMiddle(numbersArray, positionToCheck))
                {
                    Console.WriteLine("The number in position {0} is larger than its neighbours!", positionToCheck);
                }
                else
                {
                    Console.WriteLine("The number in position {0} is  Notlarger than its neighbours!", positionToCheck);
                }
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
