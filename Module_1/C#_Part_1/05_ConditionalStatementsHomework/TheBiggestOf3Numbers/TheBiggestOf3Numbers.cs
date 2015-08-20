//Problem 5. The Biggest of 3 Numbers

//Write a program that finds the biggest of three numbers.
//Examples:

//a	    b	    c	    biggest
//5	    2	    2	    5
//-2	-2	    1	    1
//-2	4	    3	    4
//0	    -2.5	5	    5
//-0.1	-0.5	-1.1	-0.1

namespace TheBiggestOf3Numbers
{
    using System;
    using System.Threading;
    using System.Globalization;

    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter nimber a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter nimber b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter nimber c: ");
            double c = double.Parse(Console.ReadLine());

            
            if ( (a < b) || (a < c) )
            {
                
                if (b < c)
                {                    
                    Console.WriteLine("The biggest number is: {0}", c);
                }
                else
                {
                    Console.WriteLine("The biggest number is: {0}", b);
                }
            }
            else 
            {
                Console.WriteLine("The biggest number is: {0}", a);
            }           
   
        }
    }
}
