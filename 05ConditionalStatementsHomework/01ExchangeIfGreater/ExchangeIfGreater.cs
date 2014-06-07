using System;

namespace _01ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.WriteLine("Please input a number: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Please input a number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            double biggerNumber = firstNumber;

            if (firstNumber > secondNumber)
            {
                firstNumber = secondNumber;
                secondNumber = biggerNumber;
                Console.WriteLine("{0} {1}", firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("{0} {1}", firstNumber, secondNumber);
            }
        }
    }
}
