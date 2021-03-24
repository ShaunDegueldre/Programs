using System;

namespace Return
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call of method to print to console the return of the inputted parameter
            Console.WriteLine(DecoratePlanet("Jupiter"));

            // Call of methods listed below 
            Console.WriteLine(DecoratePlanet("Mars"));
            Console.WriteLine("Is Pluto really a dwarf...?");
            Console.WriteLine(IsPlutoADwarf());
            Console.WriteLine("Then how many planets are there in the galaxy...?");
            Console.WriteLine(CountThePlanets());
        }
        // Creation of method decoratePlanet taking in a string parameter name planetName
        static string DecoratePlanet(string planetName)
        {
            // Returning the string with the paramerter of planet name
            return ($"Fancy Welcome to {planetName}.");
        }
        // Creation of method IsPlutoADwarf taking in no parameter and returning a bool value
        static bool IsPlutoADwarf()
        {
            return true;
        }
        // Creation of method CountThePlanets taking in no parameters and retruning a string
        static string CountThePlanets()
        {
            return "8 planets, usually";
        }
    }
}

