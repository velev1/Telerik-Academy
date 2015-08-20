//Problem 11.* Number as Words

//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
//Examples:

//numbers	number as words
//0	Zero
//9	Nine
//10	Ten
//12	Twelve
//19	Nineteen
//25	Twenty five
//98	Ninety eight
//98	Ninety eight
//273	Two hundred and seventy three
//400	Four hundred
//501	Five hundred and one
//617	Six hundred and seventeen
//711	Seven hundred and eleven
//999	Nine hundred and ninety nine


namespace NumberAsWords
{
    using System;

    class NumberAsWords
    {
        static void Main()
        {
            Console.Write("Insetr integer 0 <= n <= 999:  ");
            int? number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (number < 0)
            {
                Console.WriteLine("Error: Not valid number!");
                return;
            }

            if (number > 999)
            {
                Console.WriteLine("Error: Not valid number!");
                return;
            }

            if (number == 0)
            {
                Console.WriteLine("{0} --> zero", number);
                return;
            }


            Console.Write("{0} --> ", number);

            if ((number < 20) && (number > 9))
            {
                switch (number)
                {
                    case 10: Console.WriteLine("ten"); number = null; break;
                    case 11: Console.WriteLine("eleven"); number = null; break;
                    case 12: Console.WriteLine("twelve"); number = null; break;
                    case 13: Console.WriteLine("thirteen"); number = null; break;
                    case 14: Console.WriteLine("fourteen"); number = null; break;
                    case 15: Console.WriteLine("fifteen"); number = null; break;
                    case 16: Console.WriteLine("sixteen"); number = null; break;
                    case 17: Console.WriteLine("seventeen"); number = null; break;
                    case 18: Console.WriteLine("eighteen"); number = null; break;
                    case 19: Console.WriteLine("nineteen"); number = null; break;

                    default:
                        break;
                }
                
            }

            switch (number / 100)
            {
                case 0: break;

                case 1: if ((number / 100.0) == 1.0)
                    {
                        Console.WriteLine("one hundred"); 
                    }
                    else
                    {
                        Console.Write("one hundred and ");
                        
                    }
                    break;
                case 2: if ((number / 200.0) == 1.0)
                    {
                        Console.WriteLine("two hundred");
                    }
                    else
                    {
                        Console.Write("two hundred and ");
                    }
                    break;
                case 3: if ((number / 300.0) == 1.0)
                    {
                        Console.WriteLine("three hundred");
                    }
                    else
                    {
                        Console.Write("three hundred and ");
                    }
                    break;
                case 4: if ((number / 400.0) == 1.0)
                    {
                        Console.WriteLine("four hundred");
                    }
                    else
                    {
                        Console.Write("four hundred and ");
                    }
                    break;
                case 5: if ((number / 500.0) == 1.0)
                    {
                        Console.WriteLine("five hundred");
                    }
                    else
                    {
                        Console.Write("five hundred and ");
                    }
                    break;
                case 6: if ((number / 600.0) == 1.0)
                    {
                        Console.WriteLine("six hundred");
                    }
                    else
                    {
                        Console.Write("six hundred and ");
                    }
                    break;
                case 7: if ((number / 700.0) == 1.0)
                    {
                        Console.WriteLine("seven hundred");
                    }
                    else
                    {
                        Console.Write("seven hundred and ");
                    }
                    break;
                case 8: if ((number / 800.0) == 1.0)
                    {
                        Console.WriteLine("eight hundred");
                    }
                    else
                    {
                        Console.Write("eight hundred and ");
                    }
                    break;
                case 9: if ((number / 900.0) == 1.0)
                    {
                        Console.WriteLine("nine hundred");
                    }
                    else
                    {
                        Console.Write("nine hundred and ");
                    }
                    break;

                default: 
                    break;
            }



            switch ((number / 10) % 10)
            {
                case 0: break;
                case 1: number -= 100; break;
                case 2: Console.Write("twenty "); break;
                case 3: Console.Write("thirty "); break;
                case 4: Console.Write("forty "); break;
                case 5: Console.Write("fifty "); break;
                case 6: Console.Write("sixty "); break;
                case 7: Console.Write("seventy "); break;
                case 8: Console.Write("eighty "); break;
                case 9: Console.Write("ninety "); break;
                default:
                    break;
            }

            switch (number)
            {
                case 10: Console.WriteLine("ten"); number = null;  break;
                case 11: Console.WriteLine("eleven"); number = null; break;
                case 12: Console.WriteLine("twelve"); number = null; break;
                case 13: Console.WriteLine("thirteen"); number = null; break;
                case 14: Console.WriteLine("fourteen"); number = null; break;
                case 15: Console.WriteLine("fifteen"); number = null; break;
                case 16: Console.WriteLine("sixteen"); number = null; break;
                case 17: Console.WriteLine("seventeen"); number = null; break;
                case 18: Console.WriteLine("eighteen"); number = null; break;
                case 19: Console.WriteLine("nineteen"); number = null; break;
            
                default:
                    break;
            }

            switch (number % 10)
            {
                case 0: Console.WriteLine(); break;          
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;

                default:
                    break;
            }            
        }
    }
}
