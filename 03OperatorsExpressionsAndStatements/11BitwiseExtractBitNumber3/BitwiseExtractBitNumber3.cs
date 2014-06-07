using System;

namespace _11BitwiseExtractBitNumber3
{
    class BitwiseExtractBitNumber3
    {
        static void Main()
        {
            Console.WriteLine("Please input an unsigned integer: ");
            string input = Console.ReadLine();
            uint number = uint.Parse(input);

            Console.WriteLine("Binary representation of the integer:");
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));

            uint moveNumber = number >> 3;
            uint bit = moveNumber & 1;
            Console.WriteLine("The value of the bit #3 is:");
            Console.WriteLine(Convert.ToString(bit));
        }
    }
}
