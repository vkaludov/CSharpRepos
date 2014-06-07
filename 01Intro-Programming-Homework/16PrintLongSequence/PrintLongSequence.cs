using System;

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main()
        {
            Console.BufferHeight = 1001;
            for (int member = 2; member < 1001; member++)
            {
                if (member % 2 == 0)
                    Console.WriteLine(member);
                else
                    Console.WriteLine(member * -1);
            }            
        }
    }
}
