using System;

namespace NamedArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calling method VisitPlanets only providing parameters of numberOfPlanets and name.  
            // By naming the parameters you can only select the parameters you want but only if all have a default
            VisitPlanets(numberOfPlanets: 2, name: "Shaun");
        }

        static void VisitPlanets(
          string adjective = "brave",
          string name = "Cosmonaut",
          int numberOfPlanets = 0,
          double gForce = 4.2)
        {
            Console.WriteLine($"Welcome back, {adjective} {name}.");
            Console.WriteLine($"You visited {numberOfPlanets} new planets...");
            Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
        }
    }
}
