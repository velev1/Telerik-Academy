//Problem 12. Extract Bit from Integer

//Write an expression that extracts from given integer n the value of given bit at index p.
//Examples:

//n	    binary      representation	p	bit @ p
//5	    00000000    00000101	    2	1
//0	    00000000    00000000	    9	0
//15	00000000    00001111	    1	1
//5343	00010100    11011111	    7	1
//62241	11110011    00100001	    11	0


namespace ExtractBitFromInteger
{
    using System;

    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.Write("Insert integer: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Insert bit possition to be extracted (left to right): ");
            int bitPos = int.Parse(Console.ReadLine());
            int bitAtRight = num >> bitPos;
            int bit = bitAtRight & 1;
            Console.WriteLine("Tne bit at position {0} of integer {1} is: {2}!", bitPos, num, bit);
        }
    }
}
