namespace StringsAndObjects
{
    using System;
    class StringsObjects
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello +" " + world;
            string helloWorldStr = helloWorld.ToString();
            Console.WriteLine(helloWorldStr);
        }
    }
}
