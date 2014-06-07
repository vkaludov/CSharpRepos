using System;
using System.Numerics;

class PrimeChecker
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine("Prime? " + IsPrime(n));
    }

    static bool IsPrime(long n)
    {
        if (n <= 1)
        {
            return false;
        }
        else
        {        
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

