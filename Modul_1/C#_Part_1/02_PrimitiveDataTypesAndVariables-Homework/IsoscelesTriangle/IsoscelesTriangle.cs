//Problem 8. Isosceles Triangle

//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©

//  © ©

// ©   ©

//© © © ©



namespace IsoscelesTriangle
{
    using System;


    class IsoscelesTriangle
    {
        
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char c = '©';
            char s = ' ';
            Console.WriteLine("{0}{0}{0}{1}{0}{0}{0}", s, c);
            Console.WriteLine();
            Console.WriteLine("{0}{0}{1}{0}{1}{0}{0}", s, c);
            Console.WriteLine();
            Console.WriteLine("{0}{1}{0}{0}{0}{1}{0}", s, c);
            Console.WriteLine();
            Console.WriteLine("{1}{0}{1}{0}{1}{0}{1}", s, c);
        }
    }
}
