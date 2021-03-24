using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call of each method within main program
            NamePets("joan", "alex", "jim");
            NamePets("alex", "jim");
            NamePets();
        }
        // All methods are named NamePets but each calls different number of parameters
        // Based on the number of parameters called in the method in the main program determines which one gets used
        static void NamePets(string name1, string name2)
        {
            Console.WriteLine($"Your pets {name1} and {name2} will be joining your voyage across space!");
        }
        static void NamePets(string name1, string name2, string name3)
        {
            Console.WriteLine($"Your pets {name1}, {name2}, and {name3} will be joining your voyage across space!");
        }
        static void NamePets()
        {
            Console.WriteLine("Aw, you have no spacefaring pets :(");
        }
    }
}