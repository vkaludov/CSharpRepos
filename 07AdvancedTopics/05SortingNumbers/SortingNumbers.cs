using System;
using System.Linq;

class SortingNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter how many numbers the sequence should have:");
        int inputNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} integers:", inputNum);
        
        foreach (var item in SortingASequence(inputNum))
        {            
            Console.WriteLine(item);
        }
    }

    static int[] SortingASequence(int inputNum)
    {        
        int[] numbers = new int[inputNum];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The sorted sequence is as follows:");
        Array.Sort(numbers);
        return numbers;
    }
}

