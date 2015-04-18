// Problem 2. IEnumerable extensions
// Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
// sum, product, min, max, average.

namespace ExtensioMethods.ExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class IEnumerableExtensions
    {        
        public static T Sum<T>(this IEnumerable<T> collection)
            where T : IComparable, IFormattable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection should not be empty!");
            }

            dynamic sum = 0;

            foreach (var item in collection)
            {
                sum += item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
            where T : IComparable, IFormattable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection should not be empty!");
            }

            dynamic product = 1;

            foreach (var item in collection)
            {
                product *= item;
            }

            return product;
        }

        public static T Average<T>(this IEnumerable<T> collection)
            where T : IComparable, IFormattable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection should not be empty!");
            }

            dynamic sum = 0;

            foreach (var item in collection)
            {
                sum += item;
            }

            return sum / collection.Count();
        }

        public static T Min<T>(this IEnumerable<T> collection)
            where T : IComparable, IFormattable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection should not be empty!");
            }

            T min = collection.First();

            foreach (var item in collection)
            {
                if (min.CompareTo(item) == 1)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
            where T : IComparable, IFormattable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection should not be empty!");
            }

            T max = collection.First();

            foreach (var item in collection)
            {
                if (max.CompareTo(item) == -1)
                {
                    max = item;
                }
            }

            return max;
        }
    }
}
