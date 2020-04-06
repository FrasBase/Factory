using System;
using Factory.Points;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Factory Pattern example!");

            var polarPoint = Point.Factory.NewPolarPoint(10,20);

            var cartesianPoint = Point.Factory.NewCartesianPoint(100,200);

            Console.WriteLine("CartesianPoint: " + cartesianPoint + Environment.NewLine +
                                "PolarPoint: " + polarPoint + Environment.NewLine);
        }
    }
}
