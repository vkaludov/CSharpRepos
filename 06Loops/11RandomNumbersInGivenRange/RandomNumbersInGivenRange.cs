using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        if (min > max)
        {
            Console.WriteLine("min should be greater or equal max !");
        }
        else
        {
            Random rnd = new Random();
            for (int i = 0; i < number; i++)
            {
                int randomNum = rnd.Next(min, max + 1);
                Console.Write(randomNum + " ");
            }
        }
    }
}

