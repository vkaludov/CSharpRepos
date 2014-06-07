using System;

namespace _01OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.WriteLine("Please enter an integer:");
            string input = Console.ReadLine();
            int inputNum = int.Parse(input);
            bool Odd = true;

            if (inputNum % 2 == 0)
            {
                Console.WriteLine("{0} => The number is even.", !Odd);
            }
            else
            {
                Console.WriteLine("{0} => The number is odd", Odd);
            }
            }
        }
    }
