using System;

namespace _14PrintTheASCIITable
{
    class PrintTheASCIITable
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            for (int counter = 0; counter < 255; counter++)
            {
                Console.WriteLine((char)counter);
            }
        }            
    }
}
