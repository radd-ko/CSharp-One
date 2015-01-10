namespace ExtractBit
{
    using System;
    class BitExtract
    {
        static void Main()
        {
            Console.WriteLine("enter integer");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter position");
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int nAndMask = n & mask;
            int bit = nAndMask >> p;
            Console.WriteLine(bit); 
        }
    }
}
