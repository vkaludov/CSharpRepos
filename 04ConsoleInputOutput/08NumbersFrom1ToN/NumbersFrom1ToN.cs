using System;

namespace _08NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number for n:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(); // Za da e po-prigledno v konzolata
            Console.WriteLine("The numbers in the interval from 1 to {0} are:", number);

            for (int eachNumber = 1; eachNumber <= number; eachNumber++)
            {                
                Console.WriteLine(eachNumber);
            }
        }
    }
}
