using System;

namespace _02GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main()
        {          
            Console.WriteLine("Please enter weight:");
            string inputWeight = Console.ReadLine();
            double weight = double.Parse(inputWeight);
            
            Console.WriteLine("The weight on the moon will be: {0}", weight * 0.17);            
        }
    }
}
