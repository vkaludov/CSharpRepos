using System;

namespace _14ModifyABitAtGivenPosition
{
    class ModifyABitAtGivenPosition
    {
        static void Main()
        {
            Console.WriteLine("Please enter an integer n:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter an index p:");
            int index = int.Parse(Console.ReadLine());            
            Console.WriteLine("Please enter a value v (either 1 or 0):");
            int value = int.Parse(Console.ReadLine());

            Console.WriteLine("Binary representation of the number n is:");
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));

            int result = number | (value << index);
            if (value == 0)
            {
                result = (number & ~(1 << index));
            }
            Console.WriteLine("Binary result:");
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
            Console.WriteLine("Decimal result:");
            Console.WriteLine(result);
        }
    }
}
