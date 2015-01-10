namespace DivideBy7And5
{
    using System;
    class Divide
    {
        static void Main()
        {
            Console.WriteLine("Please enter integer");
            int n = int.Parse(Console.ReadLine());
            bool divisionTest = (n!=0)&&(n % 7 == 0) && (n % 5 == 0);
            Console.WriteLine(divisionTest);
        }
    }
}
