//Problem 2. Maximal sum

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaximalSum
{
    static void Main()
    {
        // Може да се променят стойностите тук - за по-лесно;
        int[,] matrix = { {10000, 2,  5,  67, 56, 25, 16, 42, 32},
                          {5, 8,  65, 27 ,5,  1,  31, 27, 13},
                          {1, 2,  8000,  67, 4,  25, 22, 31, 9},
                          {5, 85, 65, 27, 5,  8,  18, 42, 13},
                          {1, 1,  5,  7,  56, 2,  5,  56, 0},
                          {5, 3,  12, 27, 5,  19, 31, 3000, 300}  
                        };
        // Могат да бъдат променяни размерите на подматрицата
        int SubMatrixRows = 3; 
        int SubMatrixCols = 3;

        int[] maxIndexes = MaxSumSubmatrixIndex(matrix, SubMatrixRows, SubMatrixCols);

        int maxSubSum = MaxSubmatrixSum(matrix, maxIndexes, SubMatrixRows, SubMatrixCols);
        Console.WriteLine("The maximal sum for submatrix {0} x {1} is: {2}",SubMatrixRows, SubMatrixCols, maxSubSum);
        Console.WriteLine();

        PrintSubmatrix(matrix, maxIndexes, SubMatrixRows, SubMatrixCols);
    }

    static int[] MaxSumSubmatrixIndex(int[,] matrix, int rows, int cols)
    {
        int[] maxIndex = new int[2];
        int maxSum = 0;
        int temMaxSum = 0;

        for (int row = 0; row < matrix.GetLength(0) - rows + 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - cols + 1; col++)
            {

                for (int i = row; i < row + rows; i++)
                {
                    for (int j = col; j < col + cols; j++)
                    {
                        temMaxSum += matrix[i, j];
                    }
                }
                if (temMaxSum > maxSum)
                {
                    maxSum = temMaxSum;
                    maxIndex[0] = row;
                    maxIndex[1] = col;
                }

                temMaxSum = 0;
            }
        }

        return maxIndex;
    }

    static int MaxSubmatrixSum(int[,] matrix, int[] indexes, int n, int m)
    {
        int maxSum = 0;

        for (int row = indexes[0]; row < indexes[0] + n; row++)
        {
            for (int col = indexes[1]; col < indexes[1] + m; col++)
            {
                maxSum += matrix[row, col];
            }
        }

        return maxSum;
    }

    static void PrintSubmatrix(int[,] matrix, int[] indexes, int n, int m)
    {
        for (int row = indexes[0]; row < indexes[0] + n; row++)
        {
            for (int col = indexes[1]; col < indexes[1] + m; col++)
            {
                Console.Write("{0, 5}", matrix[row, col]);
            }

            Console.WriteLine();
            Console.WriteLine();
            
        }
    }
}
