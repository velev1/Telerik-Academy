using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Problem1
{
    static void Main()
    {
        long A = long.Parse(Console.ReadLine());
        long B = long.Parse(Console.ReadLine());
        long C = long.Parse(Console.ReadLine());

        long max = Math.Max(A, B );
        max = Math.Max(max, C);
        long min = Math.Min(A, B);
        min = Math.Min(min, C);

        double avr = (A + B + C) / 3.0;
        Console.WriteLine(max);
        Console.WriteLine(min);
        Console.WriteLine("{0:F3}", avr);
    }
}

