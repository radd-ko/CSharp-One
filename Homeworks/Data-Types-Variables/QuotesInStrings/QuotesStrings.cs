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
