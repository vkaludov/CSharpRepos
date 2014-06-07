using System;
using System.Collections.Generic;
using System.Linq;

class CountOfNames
{
    static void Main()
    {
        string inputNames = Console.ReadLine();
        List<string> names = inputNames.Split(' ').ToList<string>(); // transforms the input into a list.
        names.Sort();

        int counter = 1;
        for (int i = 1; i < names.Count; i++)
        {
            if (names[i] == names[i - 1])
            {
                counter++;
            }
            else
            {
                Console.WriteLine("{0} -> {1}", names[i-1], counter);
                counter = 1;
            }
            // the following if construction is for the last member, otherwise it won't appear in the console
            if (i == (names.Count - 1))
            {
                Console.WriteLine("{0} -> {1}", names[i], counter);
            }
        }
    }
}

