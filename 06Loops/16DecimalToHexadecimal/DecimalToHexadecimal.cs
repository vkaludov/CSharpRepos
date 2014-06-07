using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Input a number in decimal format: ");
        long decimalNumber = long.Parse(Console.ReadLine());
        long? remainder = null;
        string hexNumber = "";

        while (decimalNumber > 0)
        {
            remainder = decimalNumber % 16;
            switch (remainder)
            {
                case 10: hexNumber = "A" + hexNumber; break;
                case 11: hexNumber = "B" + hexNumber; break;
                case 12: hexNumber = "C" + hexNumber; break;
                case 13: hexNumber = "D" + hexNumber; break;
                case 14: hexNumber = "E" + hexNumber; break;
                case 15: hexNumber = "F" + hexNumber; break;
                default: hexNumber = remainder.ToString() + hexNumber; break;
            }
            decimalNumber /= 16;
        }
        Console.WriteLine(hexNumber);
    }    
}

