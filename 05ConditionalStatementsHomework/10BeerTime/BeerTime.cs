using System;
using System.Globalization;

class BeerTime
{
    static void Main(string[] args)
    {
        CultureInfo enUS = new CultureInfo("en-US"); 
        Console.WriteLine(@"Please enter a time in format ""hh:mm tt""");
        string input = Console.ReadLine();
        DateTime time;             
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("3:00 AM");

        if (DateTime.TryParseExact(input, "h:mm tt", enUS, DateTimeStyles.None, out time))
	    {
            if (time >= startTime || time < endTime)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else        
        {
            Console.WriteLine("invalid time");
        }
    }
}

