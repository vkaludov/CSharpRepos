using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Input an integer between 1 and 100: ");
        int number = int.Parse(Console.ReadLine());
        int doubleNumber = number * 2;
        double numberFactoriel = 1;
        double doubleNumFactoriel = 1;
        double catalanFormula = 1;

        // If n = 3 for example -> (2n)! / (n+1)!. n! = 6.5.(4.3.2.1) / (4.3.2.1).3.2.1  In this case we can remove
        // (4.3.2.1) from the equation. so we can use a cycle that will give us the numbers from (n + 2) to 2n.
        // In this example there will be the numbers 5 and 6. Then there is an additional for cycle that will calculate 
        // n! . In the end we will just divide the result from the first cycle with the result from the second one.

        for (int i = number + 2; i <= doubleNumber; i++)
        {
            doubleNumFactoriel *= i;
        }
        for (int j = 1; j <= number; j++)
        {
            numberFactoriel *= j;
        }
        catalanFormula = doubleNumFactoriel / numberFactoriel;
        Console.WriteLine("The {0} Catalan Number is: {1}", number, catalanFormula);
    }
}

