using System;

namespace _05FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {                       
            Console.WriteLine("Please enter an integer a from 0 to 500:");
            uint numberA = uint.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a floating point b:");
            float numberB = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a floating point c:");
            float numberC = float.Parse(Console.ReadLine());

            string numberBinary = Convert.ToString(numberA, 2).PadLeft(10, '0');
            
            if (numberA >= 0 && numberA <= 500) // checks if a is between 0 and 500
            {
                Console.WriteLine("|{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|", numberA, numberBinary, numberB, numberC);
            }
            else
            {
                Console.WriteLine("a should be between 0 and 500 !");
            }
        }
    }
}
