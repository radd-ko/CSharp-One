namespace CircleAndRectangle
{
    using System;
    class CircleRectagle
    {
        static void Main()
        {
            //(x - center_x)^2 + (y - center_y)^2 < radius^2
            //Write an expression that checks for given point (x, y) if it is within the 
            //circle K({1, 1}, 1.5) and out of the 
            //rectangle R(top=1, left=-1, width=6, height=2)
            Console.WriteLine("enter point X");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("enter point Y");
            double y = double.Parse(Console.ReadLine());
            bool inCircle = ((x - 1)*(x - 1)+(y - 1)*(y - 1))<=1.5*1.5;
            bool outRect = (x <= -1 || x >= 5) || (y <= -1 || y >= 1);
            if (inCircle&&outRect)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
