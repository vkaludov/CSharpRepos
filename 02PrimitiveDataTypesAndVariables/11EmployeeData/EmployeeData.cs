using System;

namespace _11EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Rambo";
            string lastName = "Silek";
            byte Age = 23;
            string Gender = "m";
            ulong PersonalID = 8306112507;
            uint EmployeeID = 27560000;

            Console.WriteLine("First Name: {0}\nLast Name: {1}\nAge: {2}\nGender: {3}", firstName, lastName, Age, Gender);
            Console.WriteLine("Personal ID number: {0}\nUnique employee number: {1}", PersonalID, EmployeeID);
            // For a better understanding of the code, the writeline is separated in two.
        }
    }
}
