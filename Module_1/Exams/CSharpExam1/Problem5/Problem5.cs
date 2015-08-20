using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Problem5
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n,1];


        for (int i = 0; i < n; i++)
        {
            long num = long.Parse(Console.ReadLine());
            string numToString = Convert.ToString(num, 2).PadLeft(29, '0');

            matrix[i, 0] = numToString;
            
        }

        ////print input
        //for (int row = 0; row < n; row++)
        //{
        //    Console.WriteLine(matrix[row,0]);
        //}

        string sInString = Convert.ToString(s, 2).PadLeft(5, '0');
        ////Print s
        //Console.WriteLine(nInString);
        //string test = "00000100100000010010010011001";
        int occCount = 0;
        

        for (int i = 0; i < n; i++)
        {
            int index = -1;

            while (true)
            {

                index = matrix[i, 0].IndexOf(sInString, index + 1 );

                if (index == -1)
                {

                    break;
                }
                

                occCount++;

            }
            
        }
        
        
      
        Console.WriteLine(occCount);
            
            

    }
}
