using System;

namespace _03CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.WriteLine("Enter a value for the radius of the circle r: ");
            double radius = double.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine("The perimeter of the circle equals: {0:0.00}", perimeter);

            double area = Math.PI * radius * radius;
            Console.WriteLine("The area of the circle equals: {0:0.00}", area);
        }
    }
}
