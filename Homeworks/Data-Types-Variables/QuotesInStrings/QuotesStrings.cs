//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.
namespace QuotesInStrings
{
    using System;
    class QuotesStrings
    {
        static void Main()
        {
            string escapeChar = "The \"use\" of quotations causes difficulties.";
            string quotedStr = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(escapeChar);
            Console.WriteLine(quotedStr);
        }
    }
}
