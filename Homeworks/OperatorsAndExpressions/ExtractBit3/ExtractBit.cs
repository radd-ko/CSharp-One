namespace ExtractBit3
{
    using System;
    class ExtractBit
    {
        static void Main()
        {
            Console.WriteLine("enter integer");
            int n = int.Parse(Console.ReadLine());
            int p = 3;               
            int mask = 1 << p;        
            int nAndMask = n & mask;  
            int bit = nAndMask >> p;  
            Console.WriteLine(bit);   

        }
    }
}
