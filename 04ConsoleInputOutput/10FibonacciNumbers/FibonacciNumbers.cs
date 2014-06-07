using System;

namespace _10FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            int firstMember = 0;
            int secondMember = 1;
            int thirdMember = 0;

            if (number == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine("The Fibonacci sequence is as follows:");
                Console.Write(firstMember + " " + secondMember + " ");
                for (int i = 2; i < number; i++)
                {
                    thirdMember = firstMember + secondMember;
                    Console.Write(thirdMember + " ");
                    firstMember = secondMember;
                    secondMember = thirdMember;
                }
            }
        }
    }
}
