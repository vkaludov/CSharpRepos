﻿using System;

namespace _08DigitAsWord
{
    class DigitAsWord
    {
        static void Main()
        {
            Console.WriteLine("Enter a number from 0 to 9: ");
            string input = Console.ReadLine();
            double number = 0;
            bool isNumber = double.TryParse(input, out number);

            if (isNumber)
            {
                switch (input)
                {
                    case "0":Console.WriteLine("Zero"); break;
                    case "1":Console.WriteLine("One"); break;
                    case "2":Console.WriteLine("Two"); break;
                    case "3":Console.WriteLine("Three"); break;
                    case "4":Console.WriteLine("Four"); break;
                    case "5":Console.WriteLine("Five"); break;
                    case "6":Console.WriteLine("Six"); break;
                    case "7":Console.WriteLine("Seven"); break;
                    case "8":Console.WriteLine("Eight"); break;
                    case "9":Console.WriteLine("Nine"); break;
                    default: Console.WriteLine("Not a digit"); break;
                }
            }
            else
            {
                Console.WriteLine("not a digit");
            }
        }
    }
}
