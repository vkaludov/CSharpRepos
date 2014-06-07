using System;
using System.Collections.Generic;
using System.Linq;

class LongestWordInAText
{
    static void Main()
    {
        Console.WriteLine("Enter a random text:");
        string sentence = Console.ReadLine();
        List<string> words = sentence.Split(' ', '.', ',').ToList<string>();

        // If we do not split the dot "." it will appear in the word if it is the longest.
        // The dot "." will also be counted as a word.

        List<string> wordsAscending = words.OrderBy(x => x.Length).ToList<string>(); // Sorts the list by length, ascending.
        
        //the list is already sorted, so we need the last member, because it is the longest one.
        for (int i = 0; i < wordsAscending.Count; i++)   
        {
            if (i == wordsAscending.Count - 1)
            {
                Console.WriteLine("The longest word in the sentence is: ");
                Console.WriteLine(wordsAscending[i]);
            }
            else
            {
                continue;
            }
        }

        //We can also use the following:
        // string wordsAscending = words.OrderBy(x => x.Length).Last();
        // Console.WriteLine(wordsAscending);

        //Last() will give us the last member of the "words" list, which is our longest word.
    }
}

