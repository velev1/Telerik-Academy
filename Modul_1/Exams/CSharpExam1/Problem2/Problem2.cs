using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Problem2
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        decimal result = 1;
        decimal ifDigit = 1;
        decimal ifLetter = 1;

        for (int i = 0; i < input.Length - 1; i++)      
        {

            if (i % 2 == 0)
            {
                if (input[i] <= '9' && input[i] >= '0')
                {
                    ifDigit = input[i] + s + 500m;
                    result = ifDigit / 100m;
                    Console.WriteLine("{0:F2}", result);
                }
                else if ((input[i] <= 'z' && input[i] >= 'a') || (input[i] <= 'Z' && input[i] >= 'A'))
                {
                    ifLetter = (input[i] * s) + 1000m;
                    result = ifLetter / 100m;
                    Console.WriteLine("{0:F2}", result);
                }
                else
                {
                    result = (input[i] - s) / 100m;
                    Console.WriteLine("{0:F2}", result);
                }
            }

            if (i % 2 != 0)
            {
                if (input[i] <= '9' && input[i] >= '0')
                {
                    ifLetter = input[i] + s + 500m;
                    result = ifLetter * 100m;
                    Console.WriteLine("{0}", result);
                }
                else if ((input[i] <= 'z' && input[i] >= 'a') || (input[i] <= 'Z' && input[i] >= 'A'))
                {
                    ifLetter = (input[i] * s) + 1000m;
                    result = ifLetter * 100m;
                    Console.WriteLine("{0}", result);
                }
                else
                {
                    result = (input[i] - s) * 100m;
                    Console.WriteLine("{0}", result);
                }
            }
        }
    }
}
