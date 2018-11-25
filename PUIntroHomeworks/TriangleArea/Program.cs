using System;

namespace TriangleArea
{
    class Program
    {
        static Random rand = new Random();
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            
            double triagnleHeight = rand.Next(33, 188);
            double triangleBase = rnd.Next(33, 10000);
            double triangleArea = ((0.5*triangleBase)*triagnleHeight);

            Console.WriteLine("The triangle's random height is: " + triagnleHeight);
            Console.WriteLine("The triangle's random base is: " + triangleBase);
            Console.WriteLine("The triangle's area is: {0:F2}", triangleArea);
        }
    }
}
