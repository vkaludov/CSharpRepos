using System;

namespace _09SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number n:");
            int number = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int cycle = 0; cycle < number; cycle++)
            {
                Console.WriteLine("Enter a number:");
                double numberInput = double.Parse(Console.ReadLine());
                sum += numberInput;
            }
            Console.WriteLine("The sum of the numbers is: {0}.", sum);
        }
    }
}
