using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.WriteLine("Input a number in hexadecimal format: ");
        string hexNumber = Console.ReadLine();
        long product = 1;
        long decimalNumber = 0;
        int counter = 0;

        for (int i = hexNumber.Length - 1; i >= 0; i--, counter++) 
            // in this case 16^counter, so we need counter to
            // be increasing as we go from right to left. 
            // We need i to be decreasing so that it will return the digits from right to left.
        {
            int number;
            switch (hexNumber[i])
            {
                case 'A': number = 10; break;
                case 'B': number = 11; break;
                case 'C': number = 12; break;
                case 'D': number = 13; break;
                case 'E': number = 14; break;
                case 'F': number = 15; break;
                default: number = int.Parse(hexNumber[i].ToString()) ; break;
            }
            product = number * (long)Math.Pow(16, counter); //Math.Pow returns 16^counter.
            decimalNumber += product;            
        }
        Console.WriteLine(decimalNumber);
    }
}
