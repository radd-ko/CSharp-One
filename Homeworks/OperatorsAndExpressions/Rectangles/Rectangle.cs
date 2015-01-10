namespace Rectangles
{
    using System;
    class Rectangle
    {
        static void Main()
        {
           Console.WriteLine("Please enter width in centimeters");
           double width = double.Parse(Console.ReadLine());
           Console.WriteLine("Please enter height in centimeters");
           double height = double.Parse(Console.ReadLine());
           double perimeter = 2 * (width + height);
           double area = width * height;
           Console.WriteLine("the perimeter is: {0:F2}cm", perimeter);
           Console.WriteLine("the area is {0:F2}cm{1}", area, (char)0xB2);
        }
    }
}
