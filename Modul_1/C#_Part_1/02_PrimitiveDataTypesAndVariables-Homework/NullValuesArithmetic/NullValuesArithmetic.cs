//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.


namespace NullValuesArithmetic
{
    using System;

    class NullValuesArithmetic
    {
        static void Main()
        {
            int? nullInt = null;
            double? nullDouble = 5.8;
            Console.WriteLine(nullInt + " " + nullDouble);
            nullInt = nullInt + 5;
            nullDouble = nullDouble + null;
            Console.WriteLine(nullInt + " " + nullDouble);           
        }
    }
}
