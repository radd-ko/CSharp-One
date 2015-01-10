namespace PointInCircle
{
    using System;
    class PintCircle
    {
        static void Main()
        {
            //(x - center_x)^2 + (y - center_y)^2 < radius^2
            double pointX = double.Parse(Console.ReadLine());
            double pointY = double.Parse(Console.ReadLine());
            int radius=2;
            bool test = ((pointX * pointX) + (pointY * pointY)) <= radius*radius;
            Console.WriteLine(test);
        }
    }
}
