//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and compares them element by element.




using System;

class CompareArrays
{
    
         static void Main()
        {
            Console.Write("Enter length of the arrays : ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            string[] firstArray =  new string[n];
            string[] secondArray = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter first array element number {0}: ", i + 1);
                firstArray[i] = Console.ReadLine();                
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter second array element number {0}: ", i + 1);
                secondArray[i] = Console.ReadLine();
            }
            Console.WriteLine();
           

            for (int i = 0; i < n; i++)
            {
                
                if (firstArray[i] == secondArray[i])
                {
                    Console.WriteLine("Elements nuber {0} are equal!", i + 1);
                }
                else
                {
                    Console.WriteLine("Elements nuber {0} are NOT  equal!", i + 1);
                }
                                    
            }
         
    }
}

