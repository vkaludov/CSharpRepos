using System;
using System.Collections.Generic;
using System.Linq;

class CountOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<string> letters = input.Split(' ').ToList<string>(); // transforms the input into a list.
        letters.Sort();

        int counter = 1;

        for (int i = 1; i < letters.Count; i++)
        {
            if (letters[i] == letters[i - 1])
            {
                counter++;
            }
                // when letters[i] is different that the last letter, it will go to else and print the letter and
                // the number of times it has appeard. Afterwards the counter has to be set to 1 again.
            else
            {
                Console.WriteLine("{0} -> {1}", letters[i - 1], counter);
                counter = 1;
            }
            // the following if construction is for the last member, otherwise it won't appear in the console
            if (i == letters.Count - 1)
            {
                Console.WriteLine("{0} -> {1}", letters[i], counter);
            }            
        }
    }
}