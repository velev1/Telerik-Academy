/*
Problem 4. Person class
Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
 * Override ToString() to display the information of a person and if age is not specified – to say so.
Write a program to test this functionality.
*/
namespace PersonClass
{
    using System;

    public class PersonClassMain
    {
        public static void Main()
        {
            // create Person with set age
            Person withAge = new Person("Gosho Ubavetsa", 23);

            // create Person with age not set
            Person noAge = new Person("Pesho Neubavetsa");

            // print the results
            Console.WriteLine("with age");
            Console.WriteLine(withAge);
            Console.WriteLine("\nwith age not set");
            Console.WriteLine(noAge);
        }
    }
}
