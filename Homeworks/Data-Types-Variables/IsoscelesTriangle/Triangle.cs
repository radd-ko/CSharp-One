﻿//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©
//
//  © ©
//
// ©   ©
//
//© © © ©
namespace IsoscelesTriangle
{
    using System;
    class Triangle
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char symbol = '\u00A9';
            Console.WriteLine("   {0}   \n\n  {0} {0}  \n\n {0}   {0} \n\n{0} {0} {0} {0} ", symbol);
            
        }
    }
}
