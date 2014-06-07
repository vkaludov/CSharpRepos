using System;

class MinMaxSumAvgOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter a positive integer: ");
        int linesAmount = int.Parse(Console.ReadLine());
        int number = 0;
        int min = int.MaxValue;
        int max = int.MinValue;
        double sum = 0;
        double avg = 0;

        for (int i = 0; i < linesAmount; i++)
        {
            Console.WriteLine("Please enter an integer: ");
            number = int.Parse(Console.ReadLine());
            sum += number;
            min = Math.Min(min, number);
            max = Math.Max(max, number);
        }
        avg = sum / linesAmount;
        Console.WriteLine("The minimal number is: " + min);
        Console.WriteLine("The maximal number is: " + max);
        Console.WriteLine("The sum of the {0} integers is: {1}.", linesAmount, sum);
        Console.WriteLine("The average of all numbers is {0:F2}.", avg);        
    }
}

