using System;

namespace _04MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            Console.WriteLine("Please input a number: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Please input a number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Please input a number: ");
            double thirdNumber = double.Parse(Console.ReadLine());

            int minusesCount = 0;

            if ((firstNumber == 0) || (secondNumber == 0) || (thirdNumber == 0))
            {
                Console.WriteLine("The product is 0.");                
            }         
            if (firstNumber < 0)
            {
                minusesCount++;
            }
            if (secondNumber < 0)
            {
                minusesCount++;
            }
            if (thirdNumber < 0)
            {
                minusesCount++;                
            }
            if ((minusesCount % 2 == 0) && ((firstNumber != 0) && (secondNumber != 0) && (thirdNumber != 0))) 
            {
                Console.WriteLine("The product has a \"+\" sign.");
            }
            if ((minusesCount % 2 != 0) && ((firstNumber != 0) && (secondNumber != 0) && (thirdNumber != 0)))
            {
                Console.WriteLine("The product has a \"-\" sign.");            
            }
        }
    }
}
