//Problem 6. The Biggest of Five Numbers

//Write a program that finds the biggest of five numbers by using only five if statements.
//Examples:

//a	b	c	d	e	biggest
//5	2	2	4	1	5
//-2	-22	1	0	0	1
//-2	4	3	2	0	4
//0	-2.5	0	5	5	5
//-3	-0.5	-1.1	-2	-0.1	-0.1


namespace TheBiggestOf5Numbers
{
    using System;

    class TheBiggestOf5Numbers
    {
        static void Main()
        {
            Console.Write("Insert number a: " );
            double a = double.Parse(Console.ReadLine());
            Console.Write("Insert number b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Insert number c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Insert number e: ");
            double e = double.Parse(Console.ReadLine());
            Console.Write("Insert number d: ");
            double d = double.Parse(Console.ReadLine());

            if ( (a < b) || (a < c) || (a < e) || (a < d) )
            {
                if ((b < c) || (b < e) || (b < d))
                {
                    if ( (c < e) || (c < d))
                    {
                        if (e < d)
                        {
                            Console.WriteLine("The biggest number is: {0}", d);
                        }
                        else 
                        {
                            Console.WriteLine("The biggest number is: {0}", e);
                        }
                    }
                    else 
                    {
                        Console.WriteLine("The biggest number is: {0}", c);
                    }
                }
                else 
                {
                    Console.WriteLine("The biggest number is: {0}", b);
                }
            }
            else 
            {
                Console.WriteLine("The biggest number is: {0}" , a);
            }


           
        }
    }

}