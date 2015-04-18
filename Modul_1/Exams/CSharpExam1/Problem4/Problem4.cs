using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Problem4
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        int width = (2 * n) + 1;

        int midDots = (width - d  - 2) / 2;

        if (d == 0 && n == 0)
        {
            Console.WriteLine(".");

        }
        else if (d == 1 && n == 0)
        {
            Console.WriteLine("#");
        }
        
        else  if (d >= width)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }

        else
        {
            int leftDots = midDots - n - 1;
            int rightDots = width + n - midDots;

            int botLeftDash = n - midDots;
            int botRightDash = (width) + (midDots - n - 1);

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (col <= leftDots)
                    {
                        Console.Write(".");

                    }
                    else if ((col >= rightDots) && row > n - midDots)
                    {
                        Console.Write(".");
                    }
                    else if (col == leftDots + 1)
                    {
                        Console.Write("\\");

                    }
                    else if (col == rightDots - 1)
                    {
                        Console.Write("/");
                    }

                    else if ((row == midDots) && col == n)
                    {
                        Console.Write("X");

                    }
                    else if (col == botLeftDash && row < midDots)
                    {
                        Console.Write("\\");
                        //botLeftDash++;
                    }
                    else if ((col == botRightDash && row < midDots))
                    {
                        Console.Write("/");
                        botRightDash--;

                    }
                    else if (((col > botLeftDash) && (col < botRightDash)) && row < midDots)
                    {
                        Console.Write(".");

                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                if (row < midDots)
                {
                    //botRightDash--;
                    botLeftDash++;
                }

                leftDots++;
                rightDots--;


                Console.WriteLine();

            }

            //print middle
            if (d % 2 == 0)
            {
                   Console.Write(new string('.', midDots));
            Console.Write("X");
            Console.Write(new string('#', d + 1));
            Console.Write("X");
            Console.WriteLine(new string('.', midDots));
            }
            else
            {
                Console.Write(new string('.', midDots));
                Console.Write("X");
                Console.Write(new string('#', d));
                Console.Write("X");
                Console.WriteLine(new string('.', midDots));
            }
            

            //print bot

            leftDots = midDots - 1;
            rightDots = width - midDots;

            botLeftDash = n - 1;
            botRightDash = n + 1;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (col < leftDots)
                    {
                        Console.Write(".");
                    }
                    else if (col == leftDots)
                    {
                        Console.Write("/");

                    }
                    else if (col == rightDots)
                    {
                        Console.Write("\\");
                    }
                    else if (col > rightDots)
                    {
                        Console.Write(".");
                    }
                    else if ((row == n - midDots - 1) && col == n)
                    {
                        Console.Write("X");

                    }
                    else if (col == botLeftDash && row >= n - midDots)
                    {
                        Console.Write("/");
                        botLeftDash--;
                    }
                    else if ((col == botRightDash && row >= n - midDots))
                    {
                        Console.Write("\\");
                        //botRightDash++;

                    }
                    else if (((col > botLeftDash) && (col < botRightDash)) && row >= n - midDots)
                    {
                        Console.Write(".");

                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                if (row >= n - midDots)
                {
                    botRightDash++;
                }

                leftDots--;
                rightDots++;


                Console.WriteLine();

            }
        }
       

    }
}
