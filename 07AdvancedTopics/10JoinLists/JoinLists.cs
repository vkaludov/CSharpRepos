using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        string firstLine = Console.ReadLine();
        string secondLine = Console.ReadLine();
        List<string> firstList = firstLine.Split(' ').ToList<string>();
        List<string> secondList = secondLine.Split(' ').ToList<string>();

        List<string> joinedLists = firstList.Union(secondList).ToList<string>();
        joinedLists.Sort();

        foreach (var item in joinedLists)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}