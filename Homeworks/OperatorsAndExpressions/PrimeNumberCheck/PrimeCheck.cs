namespace PrimeNumberCheck
{
    using System;
    class PrimeCheck
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            double root = Math.Sqrt(n);
            bool primeTest = true;
            for (int i =2; i <= root; i++)
            {
                
                if (n % i == 0)
                {
                    primeTest = false;
                }
                
            }
            if (n==1||n<=0)
            {
                primeTest = false;
            }
            Console.WriteLine("{0} is prime - {1}", n, primeTest);
        }
    }
}
