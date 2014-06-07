using System;

class CalculateFactoriel
{
    static void Main()
    {
        //(1 < k < n < 100)

        Console.WriteLine("Input an integer between 1 and 100: ");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Input an integer between 1 and the first number: ");
        int second = int.Parse(Console.ReadLine());
        double firstFactoriel = 1;
        double secondFactoriel = 1;
        double expression = 1; // the expression is n!/k!

        for (int i = 1; i <= first; i++)
        {            
            firstFactoriel *= i;
            secondFactoriel *= second;
            if (second > 1)  // this if will decrease the second digit everytime until it gets 1, otherwise
            {                // if k = 1 it will decrease to null and the result will be + infinity
                second--;
            }           
        }
        expression = firstFactoriel / secondFactoriel; // the expression should be outside of the for construction,
        Console.WriteLine("n!/k! = {0}", expression);  // otherwise secondFactoriel will continue to be divided to 
                                                       // firstFatoriel until i = first
    }
}

