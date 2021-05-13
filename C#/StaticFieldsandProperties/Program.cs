using System;

namespace StaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            // calling method PrintTreeFacts to check that the TreeFacts property was set
            Forest.PrintTreeFacts();
            // print the number of forests created
            Console.WriteLine(Forest.ForestsCreated); // printed to console will be 0
            // Instatiate two forest objects
            Forest f = new Forest("Amazon", "Tropical");
            Forest f1 = new Forest("Congo", "Tropical");
            // print the number of forests created now
            Console.WriteLine(Forest.ForestsCreated); // printed to console will be 0 then new line than 2
        }
    }
}
