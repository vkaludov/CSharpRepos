using System;

namespace PrintASequence
{
    class PrintASequence
    {
        static void Main()
        {
            for (int member = 2; member <= 11; member++)
            {
                if (member % 2 == 0) 
                    Console.WriteLine(member);

                else 
                    Console.WriteLine(member * -1);
            }
            
        }
    }
}
