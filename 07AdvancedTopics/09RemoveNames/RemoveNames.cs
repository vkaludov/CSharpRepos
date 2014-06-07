using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
    static void Main()
    {
        string firstList = Console.ReadLine();
        string secondList = Console.ReadLine();

        string[] firstArray = firstList.Split(' ');
        string[] secondArray = secondList.Split(' ');

        List<string> namesFirst = firstArray.ToList<string>();
        List<string> namesSecond = secondArray.ToList<string>();

        for (int i = 0; i < namesFirst.Count; i++)
        {
            for (int j = 0; j < namesSecond.Count; j++)
            {
                if (namesFirst.Contains(namesSecond[j]))
                {
                    namesFirst.Remove(namesSecond[j]);
                }
            }
        }
        foreach (var name in namesFirst)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();
    }
}