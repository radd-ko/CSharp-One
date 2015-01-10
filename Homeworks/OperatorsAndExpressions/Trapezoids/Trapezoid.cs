namespace Trapezoids
{
    using System;
    class Trapezoid
    {
        static void Main()
        {
            Console.WriteLine("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a:");
            double h = double.Parse(Console.ReadLine());
            double area = (a + b) * h / 2;
            Console.WriteLine(area);
        }
    }
}
