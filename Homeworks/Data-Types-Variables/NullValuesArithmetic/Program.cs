//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.
namespace NullValuesArithmetic
{
    using System;
    class Program
    {
        static void Main()
        {
            int? someInteger = null;
            double? someDouble = null;
            Console.WriteLine("Integer with a Null value: {0}", someInteger);
            Console.WriteLine("Double with a Null value: {0}", someDouble);
            someInteger = 9;
            someDouble = 34.61;
            Console.WriteLine("Integer with a value of 9: {0}", someInteger);
            Console.WriteLine("Double with a value of 34.61: {0}", someDouble);
        }
    }
}
