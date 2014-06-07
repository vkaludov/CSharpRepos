using System;

namespace _13CheckABitAtGivenPosition
{
    class CheckABitAtGivenPosition
    {
        static void Main()
        {
            Console.WriteLine("Please enter an integer n:");
            string input1 = Console.ReadLine();
            int number = int.Parse(input1);

            Console.WriteLine("Please enter an index p:");
            string input2 = Console.ReadLine();
            int index = int.Parse(input2);

            Console.WriteLine("The binary representation of the number n is: {0}", Convert.ToString(number, 2).PadLeft(16,'0'));
            int oneBit = 1;
            int helpingNumber = oneBit << index;
            bool isOne = true;

            if ((number & helpingNumber) != 0)
            {
                Console.WriteLine(isOne);
            }
            else
            {
                Console.WriteLine(!isOne);
            }
        }
    }
}
