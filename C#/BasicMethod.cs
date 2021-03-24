using System;

namespace DefineAMethod
{
    class Program
    {
        // Creation of Main Method
        static void Main(string[] args)
        {
            // Calling of Method VisitPlanets();
            VisitPlanets();
            // Calling NumberPlanetsVisited with the parameter of 5;
            NumberPlanetsVisited(5);
            // Calling NumberofPlanetsVisisted with no parameter but the function calls for one;
            NumberofPlanetsVisited();
        }
        // Creation of method VisitPlanets();
        static void VisitPlanets()
        {
            // What the VisitPlanets method will do
            Console.WriteLine("You visited many new planets.");
        }
        // Creation of method NumberPlanetsVisited which takes in a parameter of numberofPlanets
        static void NumberPlanetsVisited(int numberofPlanets)
        {
            // What the method NumberPlanetsVisited will do
            Console.WriteLine($"You visited {numberofPlanets} new planets.")
        }
        // Creation of method NumberofPlanetsVisited which takes in a parameter of numberofPlanets but defualts value to 0 if no parameter is put in when the funciton is called
        static void NumberofPlanetsVisited(int numberofPlanets = 0)
        {
            // What the method NumberofPlanetsVisited will do
            Console.WriteLine($"You visited {numberofPlanets} new planets.")
        }
    }
}