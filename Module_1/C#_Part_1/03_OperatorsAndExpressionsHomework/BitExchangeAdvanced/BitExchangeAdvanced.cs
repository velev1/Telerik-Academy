//Problem 16.** Bit Exchange (Advanced)

//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.
//Examples:

//n	            p	q	k	binary representation of n	            binary result	                    result
//1140867093	3	24	3	01000100 00000000 01000000 00010101	    01000010 00000000 01000000 00100101	1107312677
//4294901775	24	3	3	11111111 11111111 00000000 00001111	    11111001 11111111 00000000 00111111	4194238527
//2369124121	2	22	10	10001101 00110101 11110111 00011001	    01110001 10110101 11111000 11010001	1907751121
//987654321	    2	8	11	-	                                    -	                                overlapping
//123456789	    26	0	7	-	                                    -	                                out of range
//33333333333	-1	0	33	-	                                    -	                                out of range


namespace BitExchangeAdvanced
{
    using System;

    class BitExchangeAdvanced
    {
        static void Main()
        {
            Console.Write("Insert positive integer number: ");
            uint number = uint.Parse(Console.ReadLine());
            Console.Write("Insert first bit possition p : ");
            int p= int.Parse(Console.ReadLine());
            Console.Write("Insert second bit possition q : ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("Insert bits range to change k : ");
            int k = int.Parse(Console.ReadLine());
           


            if (((p < 0) || (q < 0) || (k < 0) || (q > 32) || (p > 32) || (k > 32) || ((p + q) > 32) || ((p + k) > 32) || ((k + q) > 32)))
            {
                Console.WriteLine("out of range");
            }

            else if ((Math.Abs(p - q)) > k)
            {
                string kBinString = "1";
                for (int i = 1; i < k; i++)
                {
                    kBinString = kBinString + "1";
                }


                int kInt = Convert.ToInt32(kBinString, 2);

                long shortBits = number >> p;
                long numberShortBits = shortBits & kInt;

                long longBits = number >> q;
                long numberLongBits = longBits & kInt;

                long maskOne = ~(kInt << q);
                long shortAtLongChanger = numberShortBits << q;
                long resultOne = (number & maskOne) | shortAtLongChanger;

                long maskTwo = ~(kInt << p);
                long LongAtShortChanger = numberLongBits << p;
                long resultTwo = (resultOne & maskTwo) | LongAtShortChanger;

                Console.WriteLine("{0} with bits {1} to {2} changed with bits {3} to {4} is: {5}", number, p, p + k - 1, q, q + k - 1, resultTwo);
            }

            else
            {
                Console.WriteLine("overlapping");                
            }                      
        }
    }
}
