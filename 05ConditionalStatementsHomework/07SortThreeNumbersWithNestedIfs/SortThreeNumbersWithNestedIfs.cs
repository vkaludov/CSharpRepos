using System;

namespace _07SortThreeNumbersWithNestedIfs
{
    class SortThreeNumbersWithNestedIfs
    {
        static void Main()
        {
            Console.WriteLine("Please input a number: ");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input a number: ");
            double second = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input a number: ");
            double third = double.Parse(Console.ReadLine());

            if (first >= second && first >= third)
            {
                if (second > third)
                {
                    Console.WriteLine("{0} {1} {2}", first, second, third);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", first, third, second);
                }           
            }
            else if (second >= first && second >= third )
            {
                if (first >= third)
                {
                    Console.WriteLine("{0} {1} {2}", second, first, third);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", second, third, first);
                }
            }
            else if (third >= first && third >= second)
            {
                if (first > second)
                {
                    Console.WriteLine("{0} {1} {2}", third, first, second);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", third, second, first);
                }
            }
        }
    }
}
