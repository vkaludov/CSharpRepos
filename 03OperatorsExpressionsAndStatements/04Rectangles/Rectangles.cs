using System;

namespace _04Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Console.WriteLine("Please input a value for the width of the rectangle: ");
            string input1 = Console.ReadLine();
            double width = double.Parse(input1);

            Console.WriteLine("Please input a value for the height of the rectangle: ");
            string input2 = Console.ReadLine();
            double height = double.Parse(input2);

            double perimeter = 2 * (height + width);
            double area = height * width;            
            Console.WriteLine("The perimeter of the rectangle is: {0}", perimeter);
            Console.WriteLine("The area of the rectangle is: {0}", area);
        }
    }
}
