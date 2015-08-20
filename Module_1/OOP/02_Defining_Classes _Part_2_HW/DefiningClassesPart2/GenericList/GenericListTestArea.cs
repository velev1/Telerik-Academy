namespace GenericList
{
    using System;
    using System.Collections.Generic;

    public class GenericListTestArea
    {
        public static void Main()
        {
            GenericList<int> testList = new GenericList<int>(3);
            testList.Add(0);
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);

            testList.RemoveByIndex(2);

            testList.Insert(2, 2);

            int index = testList.IndexOf(17);

            index = testList.Count;

            Console.WriteLine(testList.ToString());

            testList.Clear();

            Console.WriteLine(testList);

            testList.Add(4);
            testList.Add(5);
            testList.Add(6);

            Console.WriteLine(testList.Max());
            Console.WriteLine(testList);

            GenericList<string> testStrings = new GenericList<string>(2);
            testStrings.Add("tuka");
            testStrings.Add("malko");
            testStrings.Add("gluposti");
            testStrings.Add("prava");
            testStrings.Add("as");

            Console.WriteLine(testStrings.Max());
        }
    }
}
