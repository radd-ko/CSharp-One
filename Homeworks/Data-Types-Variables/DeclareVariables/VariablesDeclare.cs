//Declare five variables choosing for each of them the most appropriate of the types 
//byte, sbyte, short, ushort, int, uint, long, ulong to represent the following 
//values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
namespace DeclareVariables
{
    using System;
    class VariablesDeclare
    {
        static void Main()
        {
            int varOne = 52130;
            short varTwo = -115;
            int varThree = 4825932;
            byte varFour = 97;
            short varFive = -10000;
            Console.WriteLine("{0} -> int", varOne);
            Console.WriteLine("{0} -> short", varTwo);
            Console.WriteLine("{0} -> int", varThree);
            Console.WriteLine("{0} -> byte", varFour);
            Console.WriteLine("{0} -> short", varFive);
            

        }
    }
}
