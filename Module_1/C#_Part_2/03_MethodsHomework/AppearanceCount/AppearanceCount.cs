//Problem 4. Appearance count

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

namespace AppearanceCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class AppearanceCount
    {
        static void Main()
        {
            int[] numbersArray = { 1, 2, 3, 6, 5, 45, 54, 6, 48, 8, 9, 6, 52, 54, 65, 6, 6, 6, 6, 5, 8, 8 };
            int numToCheck = 6;

            Console.WriteLine("The number {0} appears {1} times in the array!", 
                numToCheck, NumAppearInArray(numbersArray, numToCheck));
        }

        static int NumAppearInArray(int[] numbersArray, int numToCheck)
        {
            int counter = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] == numToCheck)
                {
                    ++counter;
                }
            }

            return counter;
        }


    }
}
