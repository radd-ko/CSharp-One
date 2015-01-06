namespace AgeAfterTenYears
{
    using System;

    class AgeAfterYears
    {
        static void Main()
        {
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            if (now.DayOfYear >= birthday.DayOfYear)
            {
                int ageAfterTen = now.Year - birthday.Year + 10;
                Console.WriteLine(ageAfterTen);
            }
            else
            {
                int ageAfterTen = now.Year - birthday.Year + 9;
                Console.WriteLine(ageAfterTen);
            }
        }
    }
}
