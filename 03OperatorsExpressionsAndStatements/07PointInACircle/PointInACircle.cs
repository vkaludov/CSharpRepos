using System;

namespace _07PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            Console.WriteLine("Please enter the first coordinate x: ");
            string inputX = Console.ReadLine();
            double xCoordinate = double.Parse(inputX);

            Console.WriteLine("Please enter the second coordinate y: ");
            string inputY = Console.ReadLine();
            double yCoordinate = double.Parse(inputY);

            int radius = 2;

            if ((xCoordinate * xCoordinate) + (yCoordinate * yCoordinate) <= (radius * radius))
            {
                Console.WriteLine(true + " - The point(x,y) is inside the circle.");
            }
            else
            {
                Console.WriteLine(false + " - The point(x,y) is outside the circle.");
            }
        }
    }
}
