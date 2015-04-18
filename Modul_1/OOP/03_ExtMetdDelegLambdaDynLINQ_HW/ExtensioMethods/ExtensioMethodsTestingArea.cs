namespace ExtensioMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using ExtensioMethods.ExtensionMethods;

    public class ExtensioMethodsTestingArea
    {
        public static void Main()
        {
            StringBuilder testSb = new StringBuilder();
            testSb.Append("Pesho pravi neshto na Gosho");
            testSb = testSb.Substring(5, 5);
            Console.WriteLine(testSb);

            List<double> testList = new List<double>();
            testList.Add(2.2);
            testList.Add(5.5);
            testList.Add(3.5);
           
            Console.WriteLine(testList.Average());
            Console.WriteLine(testList.Product());
            Console.WriteLine(testList.Sum());
            Console.WriteLine(testList.Min());
            Console.WriteLine(testList.Max());

            var newTest = testList.Where(x => x > 2.5);
            Console.WriteLine(newTest.Product());
        }
    }
}
