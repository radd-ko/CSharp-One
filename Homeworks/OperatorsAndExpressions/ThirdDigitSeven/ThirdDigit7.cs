namespace ThirdDigitSeven
{
    using System;
    class ThirdDigit7
    {
        static void Main()
        {
            Console.WriteLine("Please enter integer");
            int n = int.Parse(Console.ReadLine());
            bool digitTest = ((n / 100) % 10) == 7;
            Console.WriteLine("is the third digit 7? {0}", digitTest);
        }
    }
}
