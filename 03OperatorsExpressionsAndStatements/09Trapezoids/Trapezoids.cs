using System;

namespace _09Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            Console.WriteLine("Please the first side of the trapezoids: ");
            string input1 = Console.ReadLine();
            double firstSide = double.Parse(input1);

            Console.WriteLine("Please the second side of the trapezoids: ");
            string input2 = Console.ReadLine();
            double secondSide = double.Parse(input2);

            Console.WriteLine("Please the height of the trapezoids: ");
            string input3 = Console.ReadLine();
            double height = double.Parse(input3);

            double area = ((firstSide + secondSide)) * height / 2;
            Console.WriteLine("The area of the trapezoids is: {0}", area);
        }
    }
}
