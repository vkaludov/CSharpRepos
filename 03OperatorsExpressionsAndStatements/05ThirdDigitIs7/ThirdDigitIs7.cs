using System;

namespace _05ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main()
        {
            Console.WriteLine("Please input a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            int divideByHundred = number / 100;
            int divideByTen = divideByHundred % 10;

            if (divideByTen == 7)
            {
                Console.WriteLine(true + " => The third digit is 7.");
            }
            else
            {
                Console.WriteLine(false + " => The third digit is not 7.");
            }            
        }
    }
}
