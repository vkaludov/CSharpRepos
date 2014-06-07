using System;

namespace _05TheBiggestOf3Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            Console.WriteLine("Please input a number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input a number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input a number: ");
            double thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
            {
                Console.WriteLine("The biggest number is: " + firstNumber);
            }
            else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
            {
                Console.WriteLine("The biggest number is: " + secondNumber);
            }
            else if (thirdNumber >= firstNumber && thirdNumber >= secondNumber)
            {
                Console.WriteLine("The biggest number is: " + thirdNumber);
            }
        }
    }
}
