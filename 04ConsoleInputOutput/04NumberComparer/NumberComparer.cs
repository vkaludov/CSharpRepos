using System;

namespace _04NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            Console.WriteLine("Enter a value for the first number: ");
            double firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for the second number: ");
            double secondNum = double.Parse(Console.ReadLine());

            double greater = Math.Max(firstNum, secondNum);
            Console.WriteLine("The greater number is: {0}", greater);
        }
    }
}
