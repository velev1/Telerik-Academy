//Problem 12.* Zero Subset

//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//Assume that repeating the same subset several times is not a problem.
//Examples:

//numbers	result
//3 -2 1 1 8	-2 + 1 + 1 = 0
//3 1 -7 35 22	no zero subset
//1 3 -4 -2 -1	1 + -1 = 0
//1 + 3 + -4 = 0
//3 + -2 + -1 = 0
//1 1 1 -1 -1	1 + -1 = 0
//1 + 1 + -1 + -1 = 0
//0 0 0 0 0	0 + 0 + 0 + 0 + 0 = 0
//Hint: you may check for zero each of the 32 subsets with 32 if statements.


namespace ZeroSubset
{
    using System;

    class ZeroSubset
    {
        static void Main()
        {
            Console.Write("Enter signed integer number a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter signed integer number b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter signed integer number c: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter signed integer number d: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Enter signed integer number e: ");
            int e = int.Parse(Console.ReadLine());

            int counter = 0;

            if (a + b == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, b);
                counter++;
            }
            if (a + c == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, c);
                counter++;
            }
            if (a + d == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, d);
                counter++;
            }
            if (a + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, e);
                counter++;
            }
            if (b + c == 0)
            {
                Console.WriteLine("{0} + {1} = 0", b, c);
                counter++;
            }
            if (b + d == 0)
            {
                Console.WriteLine("{0} + {1} = 0", b, d);
                counter++;
            }
            if (b + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", b, e);
                counter++;
            }
            if (c + d == 0)
            {
                Console.WriteLine("{0} + {1} = 0", c, d);
                counter++;
            }
            if (c + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0 ", c, e);
                counter++;
            }
            if (d + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", d, e);
                counter++;
            }
            if (a + b + c == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
                counter++;
            }
            if (a + b + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
                counter++;
            }
            if (a + b + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
                counter++;
            }
            if (a + c + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
                counter++;
            }
            if (a + c + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
                counter++;
            }
            if (b + c + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
                counter++;
            }
            if (b + c + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
                counter++;
            }
            if (b + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
                counter++;
            }
            if (c + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
                counter++;
            }
            if (a + b + c + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
                counter++;
            }
            if (a + b + c + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
                counter++;
            }
            if (a + b + e + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, e, d);
                counter++;
            }
            if (a + c + e + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, e, d);
                counter++;
            }
            if (b + c + e + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, e, d);
                counter++;
            }
            if (a + b + c + e + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0",a, b, c, e, d);
                counter++;
            }
            if (a == 0)
            {
                Console.WriteLine("{0} = 0", a);
                counter++;
            }
            if (b == 0)
            {
                Console.WriteLine("{0} = 0", b);
                counter++;
            }
            if (c == 0)
            {
                Console.WriteLine("{0} = 0", c);
                counter++;
            }
            if (d == 0)
            {
                Console.WriteLine("{0} = 0", d);
                counter++;
            }
            if (e == 0)
            {
                Console.WriteLine("{0} = 0", e);
                counter++;
            }
            if (counter == 0)
            {
                Console.WriteLine("no zero subset");
            }
            Console.WriteLine("There ate total {0} subsets with sum 0", counter);
        }
    }
}
