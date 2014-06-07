using System;
using System.Numerics;

class FibonacciNumbers
{    
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Fib(n));
    }

    private static int Fib(int n)
    {
        int firstNum = 0;
        int secondNum = 1;
        int thirdNum = 0;

        if (n == 0)
        {
            return 1;
        }
        else
        {
           for (int i = 1; i <= n; i++)
			{
               thirdNum = firstNum + secondNum;
               firstNum = secondNum;
               secondNum = thirdNum;
                   if (i == n)
	                {
                        return thirdNum;
	                }
			}
           return 0;
        }
    }

}
