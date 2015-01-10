//Which of the following values can be assigned to a variable of type float and which to a variable of 
//type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.
namespace FloatDouble
{
    using System;
    class FloatOrDouble
    {
        static void Main()
        {
            float floatOne = 12.345f;
            float floatTwo = 3456.0912f;
            double doubleOne = 34.567839023;
            double doubleTwo = 8923.1234857;
            Console.WriteLine("float type - {0}", floatOne);
            Console.WriteLine("float type - {0}", floatTwo);
            Console.WriteLine("double type - {0}", doubleOne);
            Console.WriteLine("double type - {0}", doubleTwo);

        }
    }
}
