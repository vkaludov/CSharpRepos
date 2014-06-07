using System;

namespace _06QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number for a:");
            double numberA = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number for b:");
            double numberB = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number for c:");
            double numberC = double.Parse(Console.ReadLine());

            double discriminant = (Math.Sqrt((numberB * numberB) - (4 * numberA * numberC)));
            double firstRoot = ((-1 * numberB) - discriminant) / (2 * numberA);
            double secondRoot = ((-1 * numberB) + discriminant) / (2 * numberA);

            Console.WriteLine("The first root is equal: {0}\nThe second root is equal: {1}", firstRoot, secondRoot);
        }
    }
}
