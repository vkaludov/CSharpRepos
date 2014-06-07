using System;

namespace _03ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            while (true) // will loop until first number = 0;
            {
                Console.WriteLine("Enter the first number:");
                double firstNumber = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                double secondNumber = double.Parse(Console.ReadLine());
                double precision = 0.000001;

                bool comparison = (Math.Abs(firstNumber - secondNumber) < precision);

                if (comparison)
                    Console.WriteLine(comparison + " => The numbers are equal with 0.000001 precision.");

                else
                    Console.WriteLine(comparison + " => The numbers are not equal with 0.000001 precision.");

                if (firstNumber == 0)  // exits the loop if firstNumber = 0;
                    break;
            }
        }
    }
}
