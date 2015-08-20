//Problem 10. Employee Data

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.


namespace EmployeeData
{
    using System;

    class EmployeeData
    {
        static void Main()
        {
            string firstName = "I**";
            string lastName = "P******";
            byte age = 27;
            string gender = "m";
            long personalID = 8778987502;
            int employeeID = 27560000;
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID number: {0}", personalID);
            Console.WriteLine("Unique employee nmber: {0}", employeeID);
        }
    }
}
