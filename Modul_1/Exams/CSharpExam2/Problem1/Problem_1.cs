using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Text.RegularExpressions;


class Problem1
{
    static Dictionary<char, int> numbersOther = new Dictionary<char, int>();
    static Dictionary<byte, char> numbersDecimal = new Dictionary<byte, char>();

    static void Main()
    {
        FillDictionary();

        
        int sysFrom = 21;
        int sysTo = 26;
        string[] numbersinput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        for (int i = 0; i < numbersinput.Length; i++)
        {
            string numberFrom = numbersinput[i];
            string toDec = ToDecimal(numberFrom, sysFrom);
            string toNSys = FromDecimal(toDec, sysTo);
            Console.Write("{0} ",toNSys);

        }
    }

    static void FillDictionary()
    {
        numbersOther['a'] = 0;
        numbersOther['b'] = 1;
        numbersOther['c'] = 2;
        numbersOther['d'] = 3;
        numbersOther['e'] = 4;
        numbersOther['f'] = 5;
        numbersOther['g'] = 6;
        numbersOther['h'] = 7;
        numbersOther['i'] = 8;
        numbersOther['j'] = 9;
        numbersOther['k'] = 10;
        numbersOther['l'] = 11;
        numbersOther['m'] = 12;
        numbersOther['n'] = 13;
        numbersOther['o'] = 14;
        numbersOther['p'] = 15;
        numbersOther['q'] = 16;
        numbersOther['r'] = 17;
        numbersOther['s'] = 18;
        numbersOther['t'] = 19;
        numbersOther['u'] = 20;
        numbersOther['v'] = 21;
        numbersOther['w'] = 22;
        numbersOther['x'] = 23;
        numbersOther['y'] = 24;
        numbersOther['z'] = 26; 

        numbersDecimal[0]  = 'a';
        numbersDecimal[1]  = 'b';
        numbersDecimal[2]  = 'c';
        numbersDecimal[3]  = 'd';
        numbersDecimal[4]  = 'e';
        numbersDecimal[5]  = 'f';
        numbersDecimal[6]  = 'g';
        numbersDecimal[7]  = 'h';
        numbersDecimal[8]  = 'i';
        numbersDecimal[9]  = 'j';
        numbersDecimal[10] = 'k';
        numbersDecimal[11] = 'l';
        numbersDecimal[12] = 'm';
        numbersDecimal[13] = 'n';
        numbersDecimal[14] = 'o';
        numbersDecimal[15] = 'p';
        numbersDecimal[16] = 'q';
        numbersDecimal[17] = 'r';
        numbersDecimal[18] = 's';
        numbersDecimal[19] = 't';
        numbersDecimal[20] = 'u';
        numbersDecimal[21] = 'v';
        numbersDecimal[22] = 'w';
        numbersDecimal[23] = 'x';
        numbersDecimal[24] = 'y';
        numbersDecimal[25] = 'z';;

    }

    static string FromDecimal(string numDec, int sysTo)
    {
        StringBuilder result = new StringBuilder();
        BigInteger decimalNumber = BigInteger.Parse(numDec);

        while (decimalNumber > 0)
        {
            byte reminder = (byte)(decimalNumber % sysTo);
            decimalNumber = decimalNumber / sysTo;
            char rem = numbersDecimal[reminder];
            result.Insert(0, rem);
        }
        if (result.Length == 0)
        {
            result.Append("0");
        }

        return result.ToString();
    }

    static string ToDecimal(string number, int sysFrom)
    {
        BigInteger inDec = 0;
        BigInteger resultDec = 0;

        for (int i = 0; i < number.Length; i++)
        {
            inDec = numbersOther[number[i]] * Pow( number.Length - i - 1, sysFrom);
            resultDec = resultDec + inDec;
        }
        string result = Convert.ToString(resultDec);
        return result;
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