using System;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest f = new Forest("Congo", "Tropical");
            f.Trees = 0;

            Console.WriteLine(f.Name);
            Console.WriteLine(f.Biome);
            // Input for constructor that takes only one argument
            Forest f1 = new Forest("Rendlesham");
            // Printing to console the Name and Biome for the constructor used with only one arguement
            Console.WriteLine(f1.Biome);
            Console.WriteLine(f1.Name);
        }
    }
}
