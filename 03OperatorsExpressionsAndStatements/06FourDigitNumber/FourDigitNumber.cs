using System;

namespace _06FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.WriteLine("Please input a four-digit number: ");
            string input = Console.ReadLine();
            int fourDigitNum = int.Parse(input);

            if (fourDigitNum.ToString().Length == 4) //if the number has more or less than 4 digits, the programm will return else!
            {
                int fourthDigit = fourDigitNum % 10;
                int thirdDigit = (fourDigitNum / 10) % 10;
                int secondDigit = (fourDigitNum / 100) % 10;
                int firstDigit = fourDigitNum / 1000;
                int sum = (fourthDigit + thirdDigit + secondDigit + firstDigit);

                Console.WriteLine("The sum of the the digits is: {0}", sum);
                Console.WriteLine("The reversed order of the digits is: {0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);
                Console.WriteLine("When the last digit goes first: {0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thirdDigit);
                Console.WriteLine("The second and third digits exchanged: {0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit);                
            }
            else
            {
                Console.WriteLine("The number should have only 4 digits and cannot start with 0 !");
            }
        }
    }
}
