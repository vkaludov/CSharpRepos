using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main()
    {
        Console.WriteLine("Enter the first number of the range:");
        int startNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number of the range:");
        int endNum = int.Parse(Console.ReadLine());

        if (startNum > endNum)
        {
            Console.WriteLine("(empty list)");
        }
        else
        {
            List<int> allPrimes = FindPrimesInRange(startNum, endNum);
            Console.WriteLine("The prime numbers in the range are:");

            for (int i = 0; i < allPrimes.Count; i++)
            {
                if (i < allPrimes.Count - 1)
                {
                    Console.Write(allPrimes[i] + ", ");
                }
                else
                {
                    Console.WriteLine(allPrimes[i]);
                }
            }
        }        
    }

    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> allPrimes = new List<int>();        

        if (startNum < 2)
        {
            startNum = 2;
        }

        for (int number = startNum; number <= endNum; number++)
        {
            bool isPrime = true;
            for (int counter = 2; counter <= Math.Sqrt(number); counter++)
            {
                if (number % counter == 0)
                {
                    isPrime = false;
                    break;
                }                
            }
            if (isPrime)
            {
                allPrimes.Add(number);                
            }
        }
        return allPrimes;
    }
}

