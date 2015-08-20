using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Text.RegularExpressions;


class Problem_3
{
    private static int rows;
    private static int cols;
    private static int COEF;

    static void Main()
    {
        rows = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());

        COEF = Math.Max(rows, cols);

        int moves = int.Parse(Console.ReadLine());
        int[] CODE =   Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

        BigInteger[,] matrix = new BigInteger[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = Pow(rows - i - 1 + j, 2);
            }
        }

        BigInteger sum = 0;

        int[] currentField = { rows - 1, 0 };

        for (int i = 0; i < moves; i++)
        {

            int[] nextField = NextFieldMethod(CODE[i]);

            // UP - right curr to next  currrow >= nextrow && currcol <= nextcol
            if (currentField[0] >= nextField[0] && currentField[1] <= nextField[1])
            {
                // row
                for (int r = currentField[1]; r <= nextField[1]; r++)
                {
                    BigInteger currValue = matrix[currentField[0], r];

                    if (currValue > 0)
                    {
                        sum += currValue;
                    }
                    matrix[currentField[0], r] = -1;
                }
                //col
                for (int c = nextField[0]; c <= currentField[0]; c++)
                {
                    BigInteger currValue = matrix[c, nextField[1]];

                    if (currValue > 0)
                    {
                        sum += currValue;
                    }
                    matrix[c, nextField[1]] = -1;
                }
            }
            
            // UP - left currrow >= nextrow && currcol >= nextcol
            else if (currentField[0] >= nextField[0] && currentField[1] >= nextField[1])
            {
                // row
                for (int r = nextField[1]; r <= currentField[1]; r++)
                {
                    BigInteger currValue = matrix[currentField[0], r];

                    if (currValue > 0)
                    {
                        sum += currValue;
                    }
                    matrix[currentField[0], r] = -1;
                }
                //col
                for (int c = nextField[0]; c <= currentField[0]; c++)
                {
                    BigInteger currValue = matrix[c, nextField[1]];

                    if (currValue > 0)
                    {
                        sum += currValue;
                    }
                    matrix[c, nextField[1]] = -1;
                }
            }
            // down - righr currrow < nextrow && currcol <= nextcol
            else if (currentField[0] < nextField[0] && currentField[1] <= nextField[1])
            {
                 // row
                for (int r = currentField[1]; r <= nextField[1]; r++)
                {
                    BigInteger currValue = matrix[currentField[0], r];

                    if (currValue > 0)
                    {
                        sum += currValue;
                    }
                    matrix[currentField[0], r] = -1;
                }
                //col
                for (int c = currentField[0]; c <= nextField[0]; c++)
                {
                    BigInteger currValue = matrix[c, nextField[1]];

                    if (currValue > 0)
                    {
                        sum += currValue;
                    }
                    matrix[c, nextField[1]] = -1;
                }

            }
            // down -  left  currrow < nextrow && currcol >= nextcol
            else if (currentField[0] < nextField[0] && currentField[1] >= nextField[1])
            {
                // row
                for (int r = nextField[1]; r <= currentField[1]; r++)
                {
                    BigInteger currValue = matrix[currentField[0], r];

                    if (currValue > 0)
                    {
                        sum += currValue;
                    }
                    matrix[currentField[0], r] = -1;
                }
                //col
                for (int c = currentField[0]; c <= nextField[0]; c++)
                {
                    BigInteger currValue = matrix[c, nextField[1]];

                    if (currValue > 0)
                    {
                        sum += currValue;
                    }
                    matrix[c, nextField[1]] = -1;
                }
            }
            //
            for (int j = 0; j < 2; j++)
            {
                currentField[j] = nextField[j];
            }
        }

        Console.WriteLine(sum);
    }

    static int[] NextFieldMethod(int CODE)
    {
        int[] currentCoordinates = new int[2];
        currentCoordinates[0] = CODE / COEF; //row
        currentCoordinates[1] = CODE % COEF; // col
        return currentCoordinates;
    }

    static BigInteger Pow(int pow, int number)
    {
        BigInteger res = 1;
        for (int i = 0; i < pow; i++)
        {
            res *= number;
        }

        return res;
    }
}