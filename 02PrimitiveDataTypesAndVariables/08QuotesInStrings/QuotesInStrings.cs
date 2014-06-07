using System;

namespace _08QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main()
        {
            string quote1 = "The \"use\" of quotations causes difficulties."; // using the escape sequence
            string quote2 = @"The ""use"" of quotations causes difficulties."; // quoted string using @

            Console.WriteLine(quote1);
            Console.WriteLine(quote2);
        }
    }
}
