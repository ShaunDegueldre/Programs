using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Size of big room in building project
            double bigarea = rect(2500, 1500);
            // Size of circle in building project
            double circle = cirl(375);
            // Size of triangle in building project
            double triangle = tri(750, 500);

            // Finding total amount of flooring area in building project
            double totalArea = bigarea + circle + triangle;
            // Rounding up the total area
            totalArea = Math.Ceiling(totalArea);
            // Printing to console the total area of flooring required
            Console.WriteLine(totalArea);
            Console.WriteLine($"The total area of flooring required for this project is {totalArea} square feet.");
            // Figuring cost of building project with flooring material costing 180
            double totalCost = totalArea * 180;
            // Printing to console the total cost of the project
            Console.WriteLine(totalCost);
            Console.WriteLine($"The total cost of this projects flooring amounts to {totalCost} pesos.");
        }
        // Method to determine square feet of rectangle
        static double rect(double length, double width)
        {
            return length * width;
        }
        // Method to determine square feet of circle
        static double cirl(double radius)
        {
            return (3.14 * (radius * radius));
        }
        // Method to determine square feet of triangle
        static double tri(double bottom, double height)
        {
            return (0.5 * bottom * height);
        }
    }
}
