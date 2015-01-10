//clare two integer variables a and b and assign them with 5 and 10 and after that 
//exchange their values by using some programming logic.
//Print the variable values before and after the exchange.
//Problem 10. Employee Data
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
