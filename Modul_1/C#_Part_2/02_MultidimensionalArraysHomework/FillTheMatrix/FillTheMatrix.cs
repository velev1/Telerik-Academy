// Problem 1. Fill the matrix

// Write a program that fills and prints a matrix of size (n, n) as shown below:

using System;

 public class FillTheMatrix
{
    private static void Main()
    {
        Console.Write("Enter matrix size N (1 <= N <= 20): ");

        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        int length = size;

        FillMatrixA(matrix, length);
        Console.WriteLine();
        Console.WriteLine("Matrix A");
        PrintMatrix(matrix, length);

        FillMatrixB(matrix, length);
        Console.WriteLine();
        Console.WriteLine("Matrix B");
        PrintMatrix(matrix, length);

        ResetAllMatrixElementsToZeros(matrix, length);
        FillMatrixC(matrix, length);
        Console.WriteLine();
        Console.WriteLine("Matrix C");
        PrintMatrix(matrix, length);

        ResetAllMatrixElementsToZeros(matrix, length);
        FillMatrixD(matrix, length);
        Console.WriteLine();
        Console.WriteLine("Matrix D");
        PrintMatrix(matrix, length);
    }

    private static void FillMatrixA(int[,] matrix, int length)
    {
        for (int col = 0; col < length; col++)
        {
            for (int row = 0; row < length; row++)
            {
                matrix[row, col] = (col * length) + (row + 1);
            }
        }
    }

    private static void FillMatrixB(int[,] matrix, int length)
    {
        for (int col = 0; col < length; col++)
        {
            for (int row = 0; row < length; row++)
            {
                if (col % 2 == 0)
                {
                    matrix[row, col] = (col * length) + (row + 1);
                }
                else
                {
                    matrix[row, col] = ((col + 1) * length) - row;
                }
            }
        }
    }

    private static void FillMatrixC(int[,] matrix, int length)
    {
        int number = 1;

        for (int col = 0; col < length; col++)
        {
            for (int row = length - 1; row >= 0; row--)
            {
                for (int row2 = row, col2 = col; row2 < length && col2 < length; row2++, col2++)
                {
                    if (matrix[row2, col2] == 0)
                    {
                        matrix[row2, col2] = number;
                        number++;
                    }
                }
            }
        }
    }

    private static void FillMatrixD(int[,] matrix, int length)
    {
        // модифицирано собствено решение на задача 19 от домашното за цикли от C# част 1!
        int n = length;
        string direction = "d";
        int currRow = 0;
        int currCol = 0;

        for (int i = 1; i <= n * n; i++)
        {
            if (direction == "r" && (currCol >= n || matrix[currRow, currCol] != 0))
            {
                --currCol;
                --currRow;
                direction = "u";
            }
            else if (direction == "d" && (currRow >= n || matrix[currRow, currCol] != 0))
            {
                --currRow;
                ++currCol;
                direction = "r";
            }
            else if (direction == "l" && (currCol < 0 || matrix[currRow, currCol] != 0))
            {
                ++currCol;
                ++currRow;
                direction = "d";
            }
            else if (direction == "u" && (currRow < 0 || matrix[currRow, currCol] != 0))
            {
                ++currRow;
                --currCol;
                direction = "l";
            }

            matrix[currRow, currCol] = i;

            if (direction == "r")
            {
                ++currCol;
            }
            else if (direction == "d")
            {
                ++currRow;
            }
            else if (direction == "l")
            {
                --currCol;
            }
            else if (direction == "u")
            {
                --currRow;
            }
        }
    }
    
    private static void PrintMatrix(int[,] matrix, int length)
    {
        for (int row = 0; row < length; row++)
        {
            for (int col = 0; col < length; col++)
            {
                Console.Write("{0, 3} ", matrix[row, col]);
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        Console.WriteLine();
    }

    private static void ResetAllMatrixElementsToZeros(int[,] matrix, int length)
    {
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                matrix[i, j] = 0;
            }
        }
    }
}