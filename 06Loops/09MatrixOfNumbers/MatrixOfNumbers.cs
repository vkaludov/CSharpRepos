using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Input an integer between 1 and 20: ");
        int number = int.Parse(Console.ReadLine());
        int endNum = number;
        int startNum = 1;
        for (int rows = 0; rows < number; rows++)
        {
            for (int i = startNum; i <= endNum; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            endNum++;
            startNum++;
        }
    }
}

