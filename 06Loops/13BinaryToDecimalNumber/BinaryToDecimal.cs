using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter a binary number: ");
        string binaryNum = Console.ReadLine();
        long sum = 0;
        for (int i = 0; i < binaryNum.Length; i++)
        {
            if (binaryNum[binaryNum.Length - i - 1] == '0')
            {
                continue;
            }
            else
            {
                sum += (long)(Math.Pow(2, i));
            }
        }
        Console.WriteLine(sum);
    }    
}

