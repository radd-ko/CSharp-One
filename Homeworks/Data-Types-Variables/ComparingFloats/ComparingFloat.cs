//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
namespace ComparingFloats
{
    using System;
    class ComparingFloat
    {
        static void Main()
        {
            Console.WriteLine("Enter two floating point numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (a < 0)
            {
                a *= -1;            
            }
            if (b<0)
            {
                b *= -1;
            }
            bool test = (a - b) < 0.000001;
            Console.WriteLine("Equal (with precision eps=0.000001): {0}", test);
        }
    }
}
