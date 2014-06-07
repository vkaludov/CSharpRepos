using System;

namespace AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("Enter your birthday in format dd/mm/yyyy:");
            DateTime DateOfBirth = DateTime.Parse(Console.ReadLine());
            DateTime DateToday = DateTime.Now;
            var age = DateToday.Year - DateOfBirth.Year;
            
            Console.WriteLine("You are {0} years old", age);
            Console.WriteLine("In 10 years you will be {0} years old", age + 10);

        }
    }
}
