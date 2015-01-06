namespace AgeAfterTenYears
{
    using System;

    class AgeAfterYears
    {
        static void Main()
        {
            Console.Write("Please enter your current age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age after 10 years will be: {0} years", age + 10);
        }
    }
}
