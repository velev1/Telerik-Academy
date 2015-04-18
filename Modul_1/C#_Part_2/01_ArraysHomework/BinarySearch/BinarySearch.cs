//Problem 11. Binary search

//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Пробвам с рекурсия, даже се получи май :)
namespace BinarySearch
{
    class BinarySearchAlgorithm
    {
        static void Main()
        {
            int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            int wantedNumber = 19;

            int position = (sortedArray.Length -1 ) / 2;
            int leftPosition = 0;
            int rightPosition = sortedArray.Length - 1;

            Console.WriteLine(BinarySearch(sortedArray, wantedNumber, leftPosition, position, rightPosition));
        }

        static int BinarySearch(int[] array , int N, int startPosition, int position, int endPosition )
        {
            if (array[position] == N)
            {
                return position;
            }

            if (array[position] > N)
            {
                endPosition = position;
                position = (startPosition + endPosition) / 2;

                return BinarySearch(array, N, startPosition, position, endPosition );
            }
            else
            {
                if (position == endPosition - 1)
                {
                    position = endPosition;
                }
                startPosition = position;
                position = (startPosition + endPosition) / 2;
                return BinarySearch(array, N, startPosition, position, endPosition );
            }
        }
    }
}
