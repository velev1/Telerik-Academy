using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  class Hints
    {
        static void Main()
        {   /*
            //Adding numbers to aray until input is -1
            
            long[] input = new long[32];
            int i = 0;
            bool stopper = true;
            int rows = 0;
             do
            {
                
                input[i] = long.Parse(Console.ReadLine());
                ++rows;

                if (input[i] == (-1))
                {
                    stopper = false;
                }
                ++i;


            } while (stopper);
            



            // Parse decima to binary , row by row
            
            int width = int.Parse(Console.ReadLine());


            long[,] smetalo = new long[8, width];

            for (int row = 0; row < 8; row++)
            {
                long num = long.Parse(Console.ReadLine());
                string numToString = Convert.ToString(num, 2).PadLeft(width, '0');

                for (int col = 0; col < width; col++)
                {

                    smetalo[row, col] = long.Parse(numToString[col].ToString());
                }

            }
             

            // adding bits from integers to matrix row by row
            
            int n = int.Parse(Console.ReadLine()); // rows
            int m = int.Parse(Console.ReadLine()); // cols

            int[,] matrix = new int[n, m];
            for (int row = 0; row < n; row++)
			{
                int bits = int.Parse(Console.ReadLine());
                for (int col = 0; col < m; col++)
		        {
			        matrix[row,col] = (bits >> (m - 1 - col)) & 1;
		        }      
			 
			}

            //printing matrix

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
            
            */
        }
    }

