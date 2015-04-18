using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class Problem3
{
    static void Main()
    {
        BigInteger curretResult = 1;
        BigInteger result = 1;
        BigInteger tenthResult = 1;
        int oddInput = 0;
        int tenth = 0;
        BigInteger overTenResult = 1;

        do
        {
            curretResult = 1;
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }

            if ((oddInput % 2 == 0) && oddInput <10)
            {
                if (input == "0")
                {
                    input = "1";
                }
                foreach (char digit in input)
                {
                    if (digit == '0')
                    {
                        curretResult *= (digit - '0' + 1);
                    }
                    else
                    {
                        curretResult *= (digit - '0');
                    }                    
                }
                
                result *= curretResult;
               
            }
            else if ((oddInput % 2 == 0) && oddInput > 9)
            {
                if (input == "0")
                {
                    input = "1";
                }
                foreach (char digit in input)
                {
                    if (digit == '0')
                    {
                        curretResult *= (digit - '0' + 1);
                    }
                    else
                    {
                        curretResult *= (digit - '0');
                    }
                }

                tenthResult *= curretResult;
            }

            oddInput++;

        } while (true);

        if (oddInput < 10)
        {
             Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine(result);
            Console.WriteLine(tenthResult);
        }

    }
}
