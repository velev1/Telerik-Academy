//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.
//Example 1:

//program	user
//Please choose a type:	
//1 --> int	
//2 --> double	3
//3 --> string	
//Please enter a string:	hello
//hello*	
//Example 2:

//program	user
//Please choose a type:	
//1 --> int	
//2 --> double	2
//3 --> string	
//Please enter a double:	1.5
//2.5


namespace IntDoubleOrString
{
    using System;

    class IntDoubleOrString
    {
        static void Main()
        {
            Console.WriteLine("Please choose type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            Console.WriteLine();

            string choise = Console.ReadLine();
            Console.WriteLine();

            switch (choise)
            {
                case "1":   Console.Write("Please enter int: ");                    
                            int inputI = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine(inputI + 1); 
                            Console.WriteLine(  );break;

                case "2":   Console.Write("Please enter double: ");
                            double inputD = double.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine(inputD + 1);
                            Console.WriteLine(  );break;

                case "3":   Console.Write("Please enter string: ");
                            string inputS = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine(inputS + "*"); 
                            Console.WriteLine();break;

                default: Console.WriteLine("Invalid choise!"); break;               
            }
        }
    }
}
