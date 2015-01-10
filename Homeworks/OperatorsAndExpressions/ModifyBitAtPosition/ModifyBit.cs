namespace ModifyBitAtPosition
{
    using System;
    class ModifyBit
    {
        static void Main()
        {
            Console.WriteLine("enter integer");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter bit value");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine("enter position");
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int m;
            if (v == 1)
            { 
                m = n | mask; 
            }
            else
            {
                m = n ^ mask;
            }
            Console.WriteLine(m);
        }
    }
}
