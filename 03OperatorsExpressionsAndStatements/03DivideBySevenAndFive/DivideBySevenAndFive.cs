using System;

namespace _03DivideBySevenAndFive
{
    class DivideBySevenAndFive
    {
        static void Main()
        {
            Console.WriteLine("Please input a number: ");
            string inputNum = Console.ReadLine();
            int integer = int.Parse(inputNum);

            int divide = integer % 7;
            int divide2 = integer % 5;
            bool remainder = true;

            if ((divide != 0 || divide2 != 0) || integer == 0) // "integer == 0" otherwise it will return true
            {
                Console.WriteLine("{0} => The integer cannot be divided to 7 or 5 without remainder", !remainder);
            }
            else
            {
                Console.WriteLine("{0} => The integer can be divided to 7 or 5 without remainder", remainder);                
            }           
        }
    }
}
