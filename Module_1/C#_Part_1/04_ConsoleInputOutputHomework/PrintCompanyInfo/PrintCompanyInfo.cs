//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.
//Example input:
//
//program	            user
//Company name:	        Telerik Academy
//Company address:	    31 Al. Malinov, Sofia
//Phone number:	        +359 888 55 55 555
//Fax number:	        2
//Web site:	            http://telerikacademy.com/
//Manager first name:	Nikolay
//Manager last name:	Kostov
//Manager age:	        25
//Manager phone:	    +359 2 981 981
//Example output:
//
//Telerik Academy
//Address: 231 Al. Malinov, Sofia
//Tel. +359 888 55 55 555
//Fax: (no fax)
//Web site: http://telerikacademy.com/
//Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)  

namespace PrintCompanyInfo
{
    using System;

    class PrintCompanyInfo
    {
        static void Main()
        {            
            Console.Write("Inser company name: ");
            string company = Console.ReadLine();
            Console.Write("Inser company addres name: ");
            string companyAddres = Console.ReadLine();
            Console.Write("Inser company phone number: ");
            string companyPhone = Console.ReadLine();
            Console.Write("Inser company Fax number: ");
            string companyFax = Console.ReadLine();
            Console.Write("Inser company website: ");
            string companyWebsite = Console.ReadLine();
            Console.Write("Inser Manager's first name: ");
            string mngrFirsName = Console.ReadLine();
            Console.Write("Inser Manager's last name: ");
            string mngrLastName = Console.ReadLine();
            Console.Write("Inser Manager's age: ");
            byte mngrAge = byte.Parse(Console.ReadLine());
            Console.Write("Inser Manager's phone number: ");
            string mngrPnone = Console.ReadLine();
            Console.WriteLine(); 
            Console.WriteLine();
            Console.WriteLine("Company: {0}" , company);
            Console.WriteLine("Addres: {0}" , companyAddres);
            Console.WriteLine("Tel: {0}" , companyPhone);
            Console.WriteLine("Fax: {0}", companyFax.Length <= 8 ? companyFax : "(no fax)");
            Console.WriteLine("Web site: {0}" , companyWebsite);
            Console.WriteLine("Manager: {0} {1} (age {2}, tel. {3})" , mngrFirsName, mngrLastName, mngrAge, mngrPnone);


            
        }
    }
}
