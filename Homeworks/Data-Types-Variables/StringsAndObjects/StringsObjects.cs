﻿//Declare two string variables and assign them with Hello and World.
//Declare an object variable and assign it with the concatenation of the first two variables 
//(mind adding an interval between).
//Declare a third string variable and initialize it with the value of the object variable 
//(you should perform type casting).
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
