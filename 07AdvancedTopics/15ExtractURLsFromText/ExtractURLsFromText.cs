using System;
using System.Collections.Generic;
using System.Linq;

class ExtractURLsFromText
{
    static void Main()
    {
        Console.WriteLine("Enter a text:");
        string text = Console.ReadLine();
        List<string> wordsInText = text.Split(' ', ',').ToList<string>();

        for (int i = 0; i < wordsInText.Count; i++)
        {
            if (wordsInText[i].Contains("http://") || wordsInText[i].Contains("www."))
            {
                Console.WriteLine(wordsInText[i]);
            }
        }
    }
}

