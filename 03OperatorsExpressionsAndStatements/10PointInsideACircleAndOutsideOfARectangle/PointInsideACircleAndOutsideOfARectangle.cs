using System;

namespace _10PointInsideACircleAndOutsideOfARectangle
{
    class PointInsideACircleAndOutsideOfARectangle
    {
        static void Main()
        {
            Console.WriteLine("Please enter the first coordinate x: ");
            string inputX = Console.ReadLine();
            double xCoordinate = double.Parse(inputX);

            Console.WriteLine("Please enter the second coordinate y: ");
            string inputY = Console.ReadLine();
            double yCoordinate = double.Parse(inputY);

            double radius = 1.5;
            double xCircle = xCoordinate - 1;
            double yCircle = yCoordinate - 1;

            bool withinCircle = ((xCircle * xCircle) + (yCircle * yCircle) <= (radius * radius));
            bool outsideRectangle = (yCoordinate > 1);

            if (withinCircle == true && outsideRectangle == true)
            {
                Console.WriteLine(true + " - The point(x,y) is inside the circle and outside the rectangle.");
            }
            else
            {
                Console.WriteLine(false + " - The point(x,y) is not inside the circle and outside the rectangle.");
            }
        }
    }
}
