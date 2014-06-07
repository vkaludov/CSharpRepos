using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        Console.WriteLine("Enter the first date in format dd.MM.yyyy");
        string start = Console.ReadLine();
        Console.WriteLine("Enter the second date in format dd.MM.yyyy");
        string end = Console.ReadLine();
        DateTime startDate;
        DateTime endDate;
        int difference = 1;

        if ((DateTime.TryParse(start, out startDate)) && (DateTime.TryParse(end, out endDate)))
        {
            Console.WriteLine("The difference between the two dates is: " + DaysCount(startDate, endDate, difference));            
        }
        else
        {
            Console.WriteLine("Invalid time !");
        }
    }
    static int DaysCount(DateTime startDate, DateTime endDate, int difference)
    {
        return difference = (endDate - startDate).Days;
    }
}

