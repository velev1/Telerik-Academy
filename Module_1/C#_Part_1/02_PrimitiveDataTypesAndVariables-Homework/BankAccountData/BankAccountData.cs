//Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

namespace BankAccountData
{
    using System;

    class BankAccountData
    {
        static void Main()
        {
            string firstName = "Slim";
            string middleName = "Real";
            string lastName = "Shady";
            decimal balance = 26576890.78m;
            string bankName = "HSBC Holdings plc";
            string iban = "GB29 NWBK 6016 1331 9268 19";
            ulong crCard1 = 567989543768654;
            ulong crCard2 = 659032198763842;
            ulong crCard3 = 349876328519653;
            Console.WriteLine("Account information:");
            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Middle name: {0}", middleName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Balance: {0} GBP", balance);
            Console.WriteLine("Bank: {0}", bankName);
            Console.WriteLine("IBAN: {0}", iban);
            Console.WriteLine("Credit cards asociated with this bank account:");
            Console.WriteLine("First: {0}", crCard1);
            Console.WriteLine("Second: {0}", crCard2);
            Console.WriteLine("Third: {0}", crCard3);
        }
    }
}
