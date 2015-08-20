//Problem 14. Integer calculations

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerCalculations
{
    class IntegerCalculations
    {
        static void Main()
        {
            int[] numbers = Input();
            Min(numbers);
            Max(numbers);
            Averege(numbers);
            Sum(numbers);
            Product(numbers);
            Continue();
            
        }

        static void Continue()
        {
            Console.WriteLine("\nDo it again? (Y/N): \n");
            string answer = Console.ReadLine();
            if (answer != "N" && answer != "Y")
            {
                while (true)
                {
                    Console.Write("Enter 'Y' or 'N': ");
                    answer = Console.ReadLine();
                    if (answer == "N" || answer == "Y")
                    {
                        break;
                    }
                }
            }
            if (answer == "Y")
            {
                Main();
            }
            else
            {
                Console.WriteLine("\nGood bye!\n");
                return;
            }
        }

        static void Product(int[] numbers)
        {
            long product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }

            Console.WriteLine("\nThe product of all elements is: {0}", product);

        }

       static void Min(int[] numbers)
        {
            int min = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i]; 
                }
            }

            Console.WriteLine("\nThe element with Min value is: {0}", min);
        }

        static void Max(int[] numbers)
        {
            int max = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i]; 
                }
            }

            Console.WriteLine("\nThe element with Max value is: {0}", max);
        }
        static void Averege(int[] numbers)
        {
            long sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            decimal averege = sum / (decimal)numbers.Length;

            Console.WriteLine("\nThe averege is: {0}", averege);
        }

        static long Sum(int[] numbers)
        {  
            long sum = 0;           

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("\nThe sum of all elements is: {0}", sum);

            return sum;
        }

        static int[] Input()
        {
            Console.WriteLine("\nEnter integer elements of the sequence in one lane separated by ','");
            string input = Console.ReadLine();
            if (input.Length == 0)
            {
                Console.WriteLine("\nThe sequence should NOT be empty!!\n");
                while (true)
                {
                    Console.Write("Try again? (Y/N): ");
                    string answer = Console.ReadLine();

                    if (answer == "Y" || answer == "N")
                    {
                        break;
                    }
                }
            }

            string[] inputToArray = input.Replace(" ", string.Empty).Split(',');
            int[] sequence = new int[inputToArray.Length];
            for (int i = 0; i < inputToArray.Length; i++)
            {
                sequence[i] = int.Parse(inputToArray[i]);
            }

            return sequence;
        }
    }
}
