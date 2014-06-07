using System;

namespace _07SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main()
        {
            Console.WriteLine("Please enter five numbers seperated by a free space: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += double.Parse(numbers[i]);
            }
            Console.WriteLine("The sum of the five numbers is: {0}.", sum);            
        }
    }
}
