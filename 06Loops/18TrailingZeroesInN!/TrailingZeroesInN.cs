using System;
using System.Numerics;

class TrailingZeroesInN
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        BigInteger factoriel = 1;
        int trailing = 0;

        for (int i = 1; i <= number; i++)
        {
            factoriel *= i;
        }
        Console.WriteLine(factoriel);

        for (int j = 0; j < factoriel.ToString().Length; j++)
        {
            if (factoriel.ToString()[factoriel.ToString().Length - j - 1] == '0')
            {
                trailing++;
                continue; // it will count until the digit is not 0 anymore, then it will break the loop.
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(trailing);
    }
}

