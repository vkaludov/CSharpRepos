using System;

class CalculateGCD
{
    static void Main()
    {
        Console.WriteLine("Enter an integer: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter an integer: ");
        int secondNum = int.Parse(Console.ReadLine()); ;
        int remainder;
    
        while( secondNum != 0 ) // the GCD will be in the case when secondNum == 0
        {
            remainder = firstNum % secondNum;
            firstNum = secondNum;
            secondNum = remainder;
        }      
        Console.WriteLine(firstNum);        
    }
}

