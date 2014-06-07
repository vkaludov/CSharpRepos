using System;

namespace _12ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.WriteLine("Please enter an integer n:");
            string input1 = Console.ReadLine();
            int number = int.Parse(input1);

            Console.WriteLine("Please enter an index p:");
            string input2 = Console.ReadLine();
            int index = int.Parse(input2);

            Console.WriteLine("Binary representation of the number n is:");
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));

            int oneBit = 1;
            int helpingNumber = oneBit << index;
            Console.WriteLine("The bit at index p is: {0}", (number & helpingNumber) != 0 ? 1 : 0);
        }
    }
}
