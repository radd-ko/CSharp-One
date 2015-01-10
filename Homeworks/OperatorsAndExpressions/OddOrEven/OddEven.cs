namespace OddOrEven
{
    using System;
    class OddEven
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool test = (n % 2) != 0;
            Console.WriteLine("Odd? {0}", test);
        }
    }
}
