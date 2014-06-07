using System;

class CalculateExpressionWithFactoriel
{
    static void Main()
    {
        Console.WriteLine("Input an integer between 1 and 100: ");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Input an integer between 1 and the first number: ");
        int second = int.Parse(Console.ReadLine());
        double firstFactoriel = 1;
        double secondFactoriel = 1;
        double expression = 1;
        double difference = first - second;  // difference = (n-k)
        double differenceFactoriel = 1; // differenceFactoriel = (difference)! = (n-k)!

        for (int i = 1; i <= first; i++) // this for cycle will calculate n!/k!
        {
            firstFactoriel *= i;
            secondFactoriel *= second;
            if (second > 1)
            {                
                second--;
            }
        }
        expression = firstFactoriel / secondFactoriel;       
        
        for (int j = 1; j <= difference; j++) // this for cycle will calculate (n-k)!
        {
            differenceFactoriel *= j;
        }
        double combinations = expression * (1 / differenceFactoriel); // this is the equation n!/ k!(n-k)!
        Console.WriteLine("The result is " + combinations);
    }
}

