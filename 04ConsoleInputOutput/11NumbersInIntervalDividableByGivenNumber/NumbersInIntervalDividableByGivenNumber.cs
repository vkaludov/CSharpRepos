using System;

namespace _11NumbersInIntervalDividableByGivenNumber
{
    class NumbersInIntervalDividableByGivenNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number:");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int secondNum = int.Parse(Console.ReadLine());
            int counter = 0;

            Console.WriteLine("The numbers are as follows:");
            for (int i = firstNum; i <= secondNum; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                    Console.Write(i + " ");  
                }
            }
            Console.WriteLine("\nThere are {0} numbers in the interval.", counter);         
        }
    }
}
