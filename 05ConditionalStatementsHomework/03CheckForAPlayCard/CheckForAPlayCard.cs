using System;

namespace _03CheckForAPlayCard
{
    class CheckForAPlayCard
    {
        static void Main()
        {
            Console.WriteLine("Please input a valid card sign: ");
            string input = Console.ReadLine();    
        
            int number = 0;
            bool isNumber = int.TryParse(input, out number);  // checks if input is a number or something else

            if (isNumber)
            {
                if (number >= 2 && number <= 10)
                {
                    Console.WriteLine("Yes, this is a valid card sign.");
                }
                else
                {
                    Console.WriteLine("No, this is not a valid card sign.");
                }
            }
            else
            {
                if ((input == "J") || (input == "Q") || (input == "K") || (input == "A"))
                {
                    Console.WriteLine("Yes, this is a valid card sign.");
                }
                else
                {
                    Console.WriteLine("No, this is not a valid card sign.");
                }
            }            
        }
    }
}
