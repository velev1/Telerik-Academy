//Problem 3. Sequence n matrix

//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class SequenceNMatrix
{
    static void Main()
    {
        string[,] matrix = {
                               // Diagonal left to right
                               {"aaa", "BBB", "ccc", "ddd", "eee"}, 
                               {"aaa", "aaa", "tt", "ccc", "eee"},
                               {"aaa", "ddd", "aaa", "kkk", "ccc"},
                               {"vvv", "bbb", "aaa", "aaa", "BBB"},

                               //// Horizontal
                               //{"aaa", "bbb", "ccc", "ddd", "eee"},
                               //{"AAA", "AAA", "AAA", "AAA", "AAA"},
                               //{"aaa", "bbb", "bbb", "bbb", "eee"},
                               //{"vvv", "bbb", "ccc", "aaa", "bbb"},

                               ////// Vertikal 
                               //{"aaa", "bbb", "ccc", "ddd", "CCC"},
                               //{"aaa", "aaa", "bbb", "ddd", "CCC"},
                               //{"aaa", "bbb", "bbb", "bbb", "CCC"},
                               //{"vvv", "bbb", "ccc", "aaa", "CCC"},

                               //// Vertikal right to left
                               //{"aaa", "bbb", "aaa", "KKK", "CCC"},
                               //{"aaa", "aaa", "KKK", "aaa", "bbb"},
                               //{"aaa", "KKK", "CCC", "aaa", "CCC"},
                               //{"KKK", "CCC", "ccc", "aaa", "CCC"}


                           };

        MaxSecuence(matrix);
    }

    static void MaxSecuence(string[,] matrix)
    {
        int maxSec = 0;
        int tempMaxSec = 1;
        string maxString = string.Empty;
        


        ////Findind max horiontal
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)//!!
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    for (int i = col; i < matrix.GetLength(1) - 1 && matrix[row, i] == matrix[row, i + 1]; i++)
                    {
                        ++tempMaxSec;

                        if (tempMaxSec > maxSec)
                        {
                            maxSec = tempMaxSec;
                            maxString = matrix[row, i];
                        }
                    }

                    tempMaxSec = 1;
                }
            }
        }

        //////Findind max vertical
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)//!!
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    for (int i = row; i < matrix.GetLength(0) - 1 && matrix[i, col] == matrix[i + 1, col]; i++)
                    {
                        ++tempMaxSec;

                        if (tempMaxSec > maxSec)
                        {
                            maxSec = tempMaxSec;
                            maxString = matrix[i, col];
                        }
                    }

                    tempMaxSec = 1;
                }
            }
        }

        ////Findind max Diagonal left to right
        for (int col = 0; col < matrix.GetLength(1) - 1; col++)
        {
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)//!!
            {
                for (int row2 = row, col2 = col; row2 < matrix.GetLength(0) - 1 && col2 < matrix.GetLength(1) - 1; row2++, col2++)
                {
                    if (matrix[row2, col2] == matrix[row2 + 1, col2 + 1])
                    {
                        ++tempMaxSec;
                        if (tempMaxSec > maxSec)
                        {
                            maxSec = tempMaxSec;
                            maxString = matrix[row2, col2];
                        }
                    }
                }

                tempMaxSec = 1;
            }
        }

        //Findind max Diagonal right to left
        for (int col =  matrix.GetLength(1) - 1; col >= 0; col--)
        {
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)//!!
            {
                for (int row2 = row, col2 = col; row2 < matrix.GetLength(0) - 1 && col2 >= 1; row2++, col2--)
                {
                    if (matrix[row2, col2] == matrix[row2 + 1, col2 - 1])
                    {
                        ++tempMaxSec;
                        if (tempMaxSec > maxSec)
                        {
                            maxSec = tempMaxSec;
                            maxString = matrix[row2, col2];
                        }
                    }
                }

                tempMaxSec = 1;
            }
        }

        Console.WriteLine("Max reperatin element:\n{0} \ntotal {1} times!\n",
                        String.Concat(Enumerable.Repeat(maxString + " ", maxSec)), maxSec);
    }

}

