//A bank account has a holder name (first name, middle name and last name), 
//available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate 
//data types and descriptive names.
namespace BankAccountData
{
    using System;
    class BankAccount
    {
        static void Main()
        {
            string firstName = "Stanislav";
            string midleName = "Krasimirov";
            string lastName = "Vasilev";
            string holder = firstName + " " + midleName + " " + lastName;
            decimal ballanceLV = 1934267.67M;
            string bank = "Any Bank";
            string iban = "BG47VTGU9300071865291";
            long cardVisaGold = 4870024938578674L;
            long cardVisaEl = 4870024938579857L;
            long cardVIsaGal = 4870024938577563L;
            Console.WriteLine("Holder: {0}", holder);
            Console.WriteLine("Ballance: {0}LV", ballanceLV);
            Console.WriteLine("Bank: {0}", bank);
            Console.WriteLine("IBAN: {0}", iban);
            Console.WriteLine("Visa Gold - {0}", cardVisaGold);
            Console.WriteLine("Visa Electron - {0}", cardVisaEl);
            Console.WriteLine("Visa Galaxy - {0}", cardVIsaGal);
        }
    }
}
