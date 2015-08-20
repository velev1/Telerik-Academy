/*
Problem 5. 64 Bit array
Define a class BitArray64 to hold 64 bit values inside an ulong value.
Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
*/
namespace SixtyFourBitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64 : IEnumerable<int>, IComparable
    {
        private ulong number;

        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public ulong Number
        {
            get
            {
                return this.number;
            }

            set
            {
                this.number = value;
            }
        }

        public int this[int index]
        {
            get
            {
                CheckInvalidIndex(index);               

                return (int)((this.number >> index) & 1);
            }

            set
            {
                CheckInvalidIndex(index);

                if (value != 1 && value != 0)
                {
                    throw new ArgumentException("Invalid value - allowed bit vales are 0 ane 1!");
                }

                // from homework #3 - C# 1 
                // https://msdn.microsoft.com/en-us/library/aa691377%28v=vs.71%29.aspx
                ulong  mask = ~(1UL << index);
                ulong bitChanger = (ulong)value << index;
                this.Number  = (this.Number & mask) | bitChanger;
            }
        }

        private void CheckInvalidIndex(int index)
        {
            if (index < 0 || index > 64)
            {
                throw new IndexOutOfRangeException("The index must be between 0 and 63 inlc.!");
            }
        }

        public override  bool Equals(object other)
        {
           return this.Number == ((BitArray64)other).Number;
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !first.Equals(second);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Number + " - ");
            for (int i = 63; i >= 0; i--)
            {
                sb.Append(this[i]);
            }

            return sb.ToString();
        }

        public int CompareTo(object obj)
        {
            return this.Number.CompareTo(((BitArray64)obj).number);
        }
    }
}
