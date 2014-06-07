using System;

class LongestAreaInArray
{
    static void Main()
    {
        int inputLength = int.Parse(Console.ReadLine());
        string[] words = new string[inputLength];

        for (int i = 0; i < inputLength; i++)
        {
            words[i] = Console.ReadLine();
        }

        int equalCounter = 1;
        int equalLength = 1;
        int index = 0;

        for (int i = 0; i < words.Length - 1; i++)
        {
            if (words[i] == words[i + 1])
            {
                equalCounter++;

                if (equalCounter > equalLength)
                {
                    equalLength = equalCounter;
                    index = (i + 1) - (equalLength - 1);
                }
            }
            else
            {
                equalCounter = 1;
            }
        }
        Console.WriteLine(equalLength);
        for (int i = 0; i < equalLength; i++)
        {
            Console.WriteLine(words[index]);
        }
    }
}


