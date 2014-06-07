using System;

namespace _06TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            Console.WriteLine("Please input a number: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input a number: ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input a number: ");
            double thirdNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input a number: ");
            double fourthNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input a number: ");
            double fifthNum = double.Parse(Console.ReadLine());

            if ((firstNum >= secondNum) && (firstNum >= thirdNum) && (firstNum >= fourthNum) && (firstNum >= fifthNum))
            {
                Console.WriteLine("The biggest number is: " + firstNum);
            }
            else if ((secondNum >= firstNum) && (secondNum >= thirdNum) && (secondNum >= fourthNum) && (secondNum >= fifthNum))
            {
                Console.WriteLine("The biggest number is: " + secondNum);
            }
            else if ((thirdNum >= firstNum) && (thirdNum >= secondNum) && (thirdNum >= fourthNum) && (thirdNum >= fifthNum))
            {
                Console.WriteLine("The biggest number is: " + thirdNum);
            }
            else if ((fourthNum >= firstNum) && (fourthNum >= secondNum) && (fourthNum >= thirdNum) && (fourthNum >= fifthNum))
            {
                Console.WriteLine("The biggest number is: " + fourthNum);
            }
            else if ((fifthNum >= firstNum) && (fifthNum >= secondNum) && (fifthNum >= thirdNum) && (fifthNum >= fourthNum))
            {
                Console.WriteLine("The biggest number is: " + fifthNum);
            }
        }
    }
}
