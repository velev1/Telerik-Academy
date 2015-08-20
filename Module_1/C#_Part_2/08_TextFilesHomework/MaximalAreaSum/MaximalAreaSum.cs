/*
Problem 5. Maximal area sum

Write a program that reads a text file containing a square matrix of numbers.
Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
The first line in the input file contains the size of matrix N.
Each of the next N lines contain N numbers separated by space.
The output should be a single number in a separate text file.
Example:
    
input	    output
4 
2 3 3 4 
0 2 3 4 
3 7 1 2 
4 3 3 2	    17
*/

using System;
using System.Linq;
using System.IO;

class MaximalAreaSum
{
    static void Main()
    {
        var readMatrix = new StreamReader("..\\..\\matrix.txt");

        int matrixN = int.Parse(readMatrix.ReadLine());

        int[,] matrix = new int[matrixN, matrixN];

        for (int i = 0; i < matrixN; i++)
        {
            int[] line = readMatrix.ReadLine().Split(new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).
                ToArray();

            for (int j = 0; j < line.Length; j++)
            {
                matrix[i, j] = line[j];
            }
        }

        readMatrix.Close();
        int SubMatrixRows = 2;
        int SubMatrixCols = 2;

        int[] maxIndexes = MaxSumSubmatrixIndex(matrix, SubMatrixRows, SubMatrixCols);

        int maxSubSum = MaxSubmatrixSum(matrix, maxIndexes, SubMatrixRows, SubMatrixCols);
        Console.WriteLine("The maximal sum for submatrix {0} x {1} is: {2}", SubMatrixRows, SubMatrixCols, maxSubSum);
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

