using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter several numbers separated by a space.");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < numbers.Length; i+=2)
        {
            oddProduct *= int.Parse(numbers[i]);
        }
        for (int j = 1; j < numbers.Length; j+=2)
        {
            evenProduct *= int.Parse(numbers[j]);
        }
        if (oddProduct == evenProduct)
        {
            int product = oddProduct;
            Console.WriteLine("yes");
            Console.WriteLine("product = " + product);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = " + oddProduct);
            Console.WriteLine("even_product = " + evenProduct);
        }
    }
}

