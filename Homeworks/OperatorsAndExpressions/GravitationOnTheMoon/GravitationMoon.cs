namespace GravitationOnTheMoon
{
    using System;
    class GravitationMoon
    {
        static void Main()
        {
            Console.WriteLine("Please enter your weght");
            double weightEarth = double.Parse(Console.ReadLine());
            double weightMoon = (weightEarth*0.17);
            Console.WriteLine("Your weght on the moon is: {0}", weightMoon);
        }
    }
}
