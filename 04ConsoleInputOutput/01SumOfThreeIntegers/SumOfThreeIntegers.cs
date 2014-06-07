using System;

namespace _01SumOfThreeIntegers
{
    class SumOfThreeIntegers
    {
        static void Main()
        {
            Console.WriteLine("Enter a value for a: ");
            double valueForA = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b: ");
            double valueForB = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for c: ");
            double valueForC = double.Parse(Console.ReadLine());

            double sum = valueForA + valueForB + valueForC;
            Console.WriteLine("The sum of a, b and c is: {0}", sum);
        }
    }
}
