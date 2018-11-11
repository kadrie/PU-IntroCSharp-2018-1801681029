using System;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an opiton: triangle, square or radians.");
            string option = Console.ReadLine();

            switch (option)
            {
                case "triangle":
                    Console.WriteLine("Enter a side:");
                    double triangleSide = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the height of that side.");
                    double triangleHeight = double.Parse(Console.ReadLine());
                    Console.WriteLine($"The area of the triangle is:" + TriangleArea(triangleSide, triangleHeight));
                    break;

                case "square":
                    Console.WriteLine("Enter a side.");
                    double squareSide = double.Parse(Console.ReadLine());
                    Console.WriteLine($"The area of the square is:" + SquareArea(squareSide));
                    break;
                case "radians":
                    Console.WriteLine("Enter an angle in degrees.");
                    double angleDegrees = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{angleDegrees} degrees in radians is:" + AngleInRadians(angleDegrees));
                    break;
                default:
                    Console.WriteLine("Incorrect opiton.");
                    break;

            }
        }

        static double AngleInRadians(double angleDegrees)
        {
            double angleInRadians = Math.PI / 180 * angleDegrees;

            return angleInRadians;
        }

        static double SquareArea(double squareSide)
        {
            double squareArea = squareSide * squareSide;
            return squareArea;
        }

        static double TriangleArea(double triangleSide, double triangleHeight)
        {
            double triangleArea = (triangleSide * triangleHeight) / 2;
            return triangleArea;
        }
    }       
}
