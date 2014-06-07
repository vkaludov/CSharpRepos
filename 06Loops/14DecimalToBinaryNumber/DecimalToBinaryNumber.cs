using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a decimal number of type long: ");
        long decimalNum = long.Parse(Console.ReadLine());
        string binaryNum = "";
        string counter = "";
        for (long i = decimalNum; i != 0; i /= 2)
        {
            if (i % 2 == 1)
            {
                counter = "1";
            }
            else if (i % 2 == 0)
            {
                counter = "0";
            }
            binaryNum = counter + binaryNum;
        }
        Console.WriteLine(binaryNum);
    }
}
