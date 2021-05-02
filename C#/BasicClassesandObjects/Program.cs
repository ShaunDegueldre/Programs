using System;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // providing values to the fields within the forest class
            Forest f = new Forest();
            f.Name = "Crazy";
            f.age = 400;
            f.Trees = -10;
            // since biome is set to private can only make changes in Biome
            f.Biome = "Tropical";

            // Printing to console the name of the created f forest class
            // Will print Crazy to console
            Console.WriteLine(f.Name);
            // Will print 0 to console
            Console.WriteLine(f.Trees);
            // Will print Tropical to console since private must use Biome instead of biome
            Console.WriteLine(f.Biome);
            // Call of Burn() method
            f.Burn();

            // using method to create a new object 
            Forest f1 = new Forest("Congo", "Tropical");

            // since Age is set to private f.Age = 100 would cause an error but f.age would work since .age is still public
        }
    }
}
