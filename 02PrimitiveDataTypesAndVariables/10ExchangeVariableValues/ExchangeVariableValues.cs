using System;

namespace _10ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            int number1 = 5;
            int number2 = 10;
            Console.WriteLine(number1 + " " + number2);  //returns their values before the exchange

            number1 = number2;
            number2 = number1 - 5;
            Console.WriteLine(number1 + " " + number2);  //returns their values after the exchange
        }
    }
}
