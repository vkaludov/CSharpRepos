using System;
using System.Linq;

class RandomizeTheNumbers
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        int[] numbers = new int[inputNumber];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 1;            
        }
        var shuffle = numbers.OrderBy(a => rnd.NextDouble());

        foreach (var item in shuffle)
        {
        Console.Write(item + " ");
        }
    }
}


