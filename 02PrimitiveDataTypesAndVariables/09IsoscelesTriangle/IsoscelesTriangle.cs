using System;

namespace _09IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char copyrightSymbol = '\u00a9';
            Console.WriteLine("    {0}",copyrightSymbol);
            Console.WriteLine("   {0} {1}", copyrightSymbol, copyrightSymbol);
            Console.WriteLine("  {0}   {1}", copyrightSymbol, copyrightSymbol);
            Console.WriteLine(" {0} {1} {2} {3}", copyrightSymbol, copyrightSymbol, copyrightSymbol, copyrightSymbol);
        }
    }
}
