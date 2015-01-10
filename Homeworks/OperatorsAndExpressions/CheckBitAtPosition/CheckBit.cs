namespace CheckBitAtPosition
{
    using System;
    class CheckBit
    {
        static void Main()
        {
            Console.WriteLine("enter integer");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter position");
            int p = int.Parse(Console.ReadLine());
            int mask = n >> p;

            bool result = (mask & 1)==1;
            Console.WriteLine(result);
        }
    }
}
