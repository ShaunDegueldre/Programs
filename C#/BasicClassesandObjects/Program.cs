using System;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // providing values to the fields within the forest class
            Forest f = new Forest();
            f.name = "Crazy";
            f.age = 400;
            f.trees = 10000;
            f.biome = "FULL";

            // Printing to console the name of the created f forest class
            Console.WriteLine(f.name);
        }
    }
}
