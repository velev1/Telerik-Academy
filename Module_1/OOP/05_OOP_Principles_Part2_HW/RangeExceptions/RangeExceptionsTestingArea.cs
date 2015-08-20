namespace RangeExceptions
{
    using System;

    public class RangeExceptionsTestingArea
    {
        public static void Main(string[] args)
        {
            CustumErroChecker(1, 100, 50);
            // CustumErroChecker(1, 100, 200); // decomment to check

            CustumErroChecker(new DateTime(1980, 1, 1), new DateTime(2013, 12, 31), new DateTime(1989, 2, 2));
            // CustumErroChecker(new DateTime(1980, 1, 1), new DateTime(2013, 12, 31), DateTime.Now); // decomment to check
        }

        public static void CustumErroChecker<T>(T stars, T ends, T param) where T : IComparable
        {
            if (param.CompareTo(stars) < 0 || param.CompareTo(ends) > 0)
            {
                throw new InvalidRangeException<T>("Out of range!", stars, ends);
            }
            else
            {
                Console.WriteLine("Param is in range!");
            }
        }
    }
}
