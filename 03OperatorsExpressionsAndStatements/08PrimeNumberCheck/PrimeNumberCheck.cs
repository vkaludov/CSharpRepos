using System;

namespace _08PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.WriteLine("Please input a positive number less than 100: ");
            string input = Console.ReadLine();
            int positiveNum = int.Parse(input);
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(positiveNum);
            bool prime = true;

            if (positiveNum >= 1 && positiveNum <= 100 && positiveNum != 1)
            {
                while (prime && (divider <= maxDivider))
                {
                    if (positiveNum % divider == 0)
                    {
                        prime = false;
                    }
                    divider++;
                }
                Console.WriteLine("Prime? " + prime);
            }
            else
            {
                Console.WriteLine("Prime? " + !prime);
            }
        }
    }
}