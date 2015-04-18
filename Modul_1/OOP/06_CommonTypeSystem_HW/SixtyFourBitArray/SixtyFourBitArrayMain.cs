/*
Problem 5. 64 Bit array
Define a class BitArray64 to hold 64 bit values inside an ulong value.
Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
*/
namespace SixtyFourBitArray
{
    using System;
    using System.Collections.Generic;

    public class SixtyFourBitArrayMain
    {
        public static void Main()
        {
            BitArray64 bitNum = new BitArray64(5);
            Console.WriteLine(bitNum);

            bitNum[3] = 1;

            Console.WriteLine(bitNum);
        }
    }
}