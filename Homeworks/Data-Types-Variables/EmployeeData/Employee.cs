namespace EmployeeData
{
    using System;
    class Employee
    {
        static void Main()
        {
/*First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)*/
            string firstName = "Stoyan";
            string lastName = "Ivanov";
            byte age = 31;
            char gender = 'm';
            long idNumb = 8306112507;
            int uniqueNumb = 27560098;
            Console.WriteLine("First Name: {0}", firstName);
            Console.WriteLine("Last Name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID Number: {0}", idNumb);
            Console.WriteLine("Unique Employee Number: {0}", uniqueNumb);
        }
    }
}
