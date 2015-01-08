namespace ExchangeValues
{
    using System;
    class ValuesExchange
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("before:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("and after:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            
        }
    }
}
