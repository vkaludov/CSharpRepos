using System;

namespace _13NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? NullInteger = null;
            double? NullDouble = null;

            Console.WriteLine("The integer variable with null value equals: " + NullInteger);
            Console.WriteLine("The double variable with null value equals: " + NullDouble);

            NullInteger += 7; //adding a number to the null
            NullDouble += null; // adding a null to the null

            Console.WriteLine("The integer variable with value equals: " + NullInteger);
            Console.WriteLine("The double variable with value equals: " + NullDouble);
        }
    }
}
