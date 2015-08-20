//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
//Examples:

//n	    binary      representation of n	    p	bit @ p == 1
//5 	00000000    00000101	            2	true
//0	    00000000    00000000	            9	false
//15	00000000    00001111	            1	true
//5343	00010100    11011111	            7	true
//62241	11110011    00100001	            11	false


namespace CheckBitAtGivenPosition
{
    using System;

    class CheckBitAtGivenPosition
    {
        static void Main()
        {
            Console.Write("Insert integer: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Insert bit possition to be extracted (right to left): ");
            int bitPos = int.Parse(Console.ReadLine());
            int mask = 1 << bitPos;
            int numAndMask = num & mask;
            int bit = numAndMask >> bitPos;             
            bool isOne = bit == 1;
            Console.WriteLine("Tne bit at position {0} of integer {1} is 1: {2}!", bitPos, num, isOne);

        }
    }
}
