using System;

class CalculateAnExpression
{
    static void Main()
    {
        Console.WriteLine("Input an integer for n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Input an integer for x: ");
        int x = int.Parse(Console.ReadLine());
        double nFactorial = 1;
        double xPowerN = 1;
        double sum = 0;

        for (int i = 1; i <= n; i++)        
        {
            nFactorial *= i;
            xPowerN *= x;
            sum += nFactorial / xPowerN; // In this problem the Sum = 1 + 1!/x + 2!/x^2 + … + n!/x^n
        }
        Console.WriteLine("{0:F5}", sum + 1);
    }
}

