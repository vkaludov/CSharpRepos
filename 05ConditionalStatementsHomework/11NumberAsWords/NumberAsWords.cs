﻿using System;

class NumberAsWords
{
static void Main()
{
    int number = int.Parse(Console.ReadLine());
    int firstDigit = number / 100;
    int secondDigit = number / 10 % 10;
    int thirdDigit = number % 10;

    if (number == 0)
    {
        Console.WriteLine("zero");
    }
    if (number % 100 == 0)
    {
        switch (firstDigit)
        {
            case 1: Console.Write("One hundred "); break;
            case 2: Console.Write("Two hundred "); break;
            case 3: Console.Write("Three hundred "); break;
            case 4: Console.Write("Four hundred "); break;
            case 5: Console.Write("Five hundred "); break;
            case 6: Console.Write("Six hundred "); break;
            case 7: Console.Write("Seven hundred "); break;
            case 8: Console.Write("Eight hundred "); break;
            case 9: Console.Write("Nine hundred "); break;
        }
    }
    else if (number > 100 && number <= 999)
    {
        switch (firstDigit)
        {
            case 1: Console.Write("One hundred and "); break;
            case 2: Console.Write("Two hundred and "); break;
            case 3: Console.Write("Three hundred and "); break;
            case 4: Console.Write("Four hundred and "); break;
            case 5: Console.Write("Five hundred and "); break;
            case 6: Console.Write("Six hundred and "); break;
            case 7: Console.Write("Seven hundred and "); break;
            case 8: Console.Write("Eight hundred and "); break;
            case 9: Console.Write("Nine hundred and "); break;
        }
    }
        if (secondDigit != 0 && secondDigit != 1)
        {
            switch (secondDigit)
            {
                case 2: Console.Write("twenty "); break;
                case 3: Console.Write("thirty "); break;
                case 4: Console.Write("fourty "); break;
                case 5: Console.Write("fifty "); break;
                case 6: Console.Write("sixty "); break;
                case 7: Console.Write("seventy "); break;
                case 8: Console.Write("eighty "); break;
                case 9: Console.Write("ninety "); break;
            }            
            switch (thirdDigit)
            {
                case 1: Console.Write("one "); break;
                case 2: Console.Write("two "); break;
                case 3: Console.Write("three "); break;
                case 4: Console.Write("four "); break;
                case 5: Console.Write("five "); break;
                case 6: Console.Write("six "); break;
                case 7: Console.Write("seven "); break;
                case 8: Console.Write("eight "); break;
                case 9: Console.Write("nine "); break;
            }
        }
        else if (thirdDigit != 0 && secondDigit == 0)
        {
            switch (thirdDigit)
            {
                case 1: Console.Write("one "); break;
                case 2: Console.Write("two "); break;
                case 3: Console.Write("three "); break;
                case 4: Console.Write("four "); break;
                case 5: Console.Write("five "); break;
                case 6: Console.Write("six "); break;
                case 7: Console.Write("seven "); break;
                case 8: Console.Write("eight "); break;
                case 9: Console.Write("nine "); break;
            }
        }
        if (secondDigit == 1)
        {
            switch (thirdDigit)
            {
                case 1: Console.Write("eleven "); break;
                case 2: Console.Write("twelve "); break;
                case 3: Console.Write("thirteen "); break;
                case 4: Console.Write("fourteen "); break;
                case 5: Console.Write("fifteen "); break;
                case 6: Console.Write("sixteen "); break;
                case 7: Console.Write("seventeen "); break;
                case 8: Console.Write("eighteen "); break;
                case 9: Console.Write("nineteen "); break;
            }
            if (thirdDigit == 0)
            {
                Console.Write("Ten ");
            }
        }
    }
}


