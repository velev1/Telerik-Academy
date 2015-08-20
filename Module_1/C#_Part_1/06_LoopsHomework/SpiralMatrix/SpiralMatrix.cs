//Problem 19.** Spiral Matrix

//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
//Examples:

//n = 2   matrix      n = 3   matrix      n = 4   matrix
//        1 2                 1 2 3               1  2  3  4
//        4 3                 8 9 4               12 13 14 5
//                            7 6 5               11 16 15 6
//                                                10 9  8  7

namespace SpiralMatrix
{
    using System;

    class SpiralMatrix
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Enter positive integer n (1 ≤ n ≤ 20): ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] matrix = new int[n,n];


            string direction = "r";
            int currRow = 0;
            int currCol = 0;



            for (int i = 1; i <= n * n; i++)
            {

                if (direction == "r" && (currCol >= n || matrix[currRow, currCol] != 0 ))
                {
                    --currCol;
                    ++currRow;
                    direction = "d";
                }
                else if (direction == "d" && (currRow >= n || matrix[currRow, currCol] != 0))
                {
                    --currRow;
                    --currCol;
                    direction = "l";
                }
                else if (direction == "l" && (currCol < 0 || matrix[currRow, currCol] != 0))
                {
                    ++currCol;
                    --currRow;
                    direction = "u";
                    
                }
                else if (direction == "u" && (currRow < 0 || matrix[currRow, currCol] != 0))
                {
                    ++currRow;
                    ++currCol;
                    direction = "r";
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

            Console.WriteLine(new string('-', n * 4 + 1));

            for (int row = 0; row < n; row++)
            {
                Console.Write("|");
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0, 3}|", matrix[row,col]);
                }

                
                Console.WriteLine();
                
                Console.WriteLine(new string('-', n * 4 + 1));
                
                
            }
            Console.WriteLine();


        }
    }
}
